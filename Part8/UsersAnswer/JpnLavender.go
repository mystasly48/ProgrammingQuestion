package main

import (
	"bufio"
	"fmt"
	"os"
	"strings"
)

var input = bufio.NewScanner(os.Stdin)

func main() {
	answer := processing(valueSplit(gets()), gets())
	fmt.Println(answer)
}
func processing(s1 []string, s2 string) int {
	var result int
	str := uniq(s1)
	for _, v := range str {
		if strings.Contains(s2, v) {
			result += 1
		}
	}
	return result
}

func valueSplit(value string) []string {
	return strings.Split(value, "")
}

func gets() string {
	if input.Scan() {
		return input.Text()
	} else {
		return "NoInputData"
	}
}

func uniq(args []string) []string {
	results := make([]string, 0, len(args))
	encountered := map[string]bool{}
	for i := 0; i < len(args); i++ {
		if !encountered[args[i]] {
			encountered[args[i]] = true
			results = append(results, args[i])
		}
	}
	return results
}
