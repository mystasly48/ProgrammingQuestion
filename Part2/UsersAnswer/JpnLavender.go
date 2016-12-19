package main

import (
	"bufio"
	"fmt"
	"math/rand"
	"os"
	"strconv"
	"time"
)

var input = bufio.NewScanner(os.Stdin)

func gets() string {
	if input.Scan() {
		return input.Text()
	} else {
		return "NotInputData"
	}
}

func parseint(getValue string) int {
	var parseResult int
	parseResult, _ = strconv.Atoi(getValue)
	return parseResult
}

func createRandomValue(randomRange int) int {
	rand.Seed(time.Now().UnixNano())
	return rand.Intn(randomRange)
}

func main() {
	getValue := gets()
	randomRange := parseint(getValue)
	answer := createRandomValue(randomRange)
	fmt.Println(answer)
}
