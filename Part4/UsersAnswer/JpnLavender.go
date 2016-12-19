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

func splitValueParse(inputValue string) []int {
	var result []int
	splitValue := strings.Split(inputValue, " ")
	for i := 0; i < len(splitValue); i++ {
		var parseValue int
		parseValue, _ = strconv.Atoi(splitValue[i])
		result = append(result, parseValue)
	}
	return result
}

func Calculation(splitValue []int) int {
	var useEnergy float64 = float64(splitValue[1]) / float64(splitValue[2])
	amountOfMoney := useEnergy * float64(splitValue[3])
	splitAmount := amountOfMoney / float64(splitValue[0]+1)
	reciprocatingDistance := splitAmount * 2
	return int(math.Trunc(reciprocatingDistance))
}

func main() {
	inputValue := gets()
	answer := Calculation(splitValueParse(inputValue))
	fmt.Println(answer)
}
