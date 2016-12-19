package main

import (
	"bufio"
	"fmt"
	"os"
	"strconv"
	"strings"
)

var sc = bufio.NewScanner(os.Stdin)

func main() {
	processing(gets())
}

func processing(inputValue string) {
	var splitValue []string = strings.Split(inputValue, " ")
	resultValue := make(chan int)
	var result int
	go func() {
		for _, v := range splitValue {
			value, _ := strconv.Atoi(v)
			result += value
		}
		resultValue <- result
	}()
	num := <-resultValue
	fmt.Printf("%v", num)
}

func gets() string {
	if sc.Scan() {
		return sc.Text()
	} else {
		return "NoInputData"
	}
}
