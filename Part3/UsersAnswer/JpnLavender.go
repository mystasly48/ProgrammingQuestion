package main

import (
	"bufio"
	"fmt"
	"math"
	"os"
	"strconv"
	"strings"
)

var input = bufio.NewScanner(os.Stdin)

func gets() string {
	if input.Scan() {
		return input.Text()
	} else {
		return "NotInputData"
	}
}

func inputValueSplitParse(valueNum string, inputValue string) int {
	var splitValue []string
	var result int
	splitValue = strings.Split(inputValue, " ")
	for i := 0; i < len(splitValue); i++ {
		value, _ := strconv.Atoi(splitValue[i])
		result += value
	}
	return int(math.Trunc(float64(result) * 1.08))
}

func main() {
	valueNum := gets()
	inputValue := gets()
	answer := inputValueSplitParse(valueNum, inputValue)
	fmt.Println(answer)
}
