package main

import (
	"bufio"
	"fmt"
	"os"
	"strconv"
	"strings"
)

var sc = bufio.NewScanner(os.Stdin)

func gets() string {
	if sc.Scan() {
		return sc.Text()
	} else {
		return "NoInputData"
	}
}
func main() {
	have_money, _ := strconv.Atoi(gets())
	N, _ := strconv.Atoi(gets())
	for i := 0; i < N; i++ {
		value, _ := strconv.Atoi(gets())
		have_money -= value
	}
	for _, v := range exchange(have_money) {
		for _, va := range v {
			fmt.Printf("%v ", va)
		}
	}
}

func exchange(have_money int) [][]int {
	arr := [][]int{{0, 0}, {0, 0}, {0, 0}, {0, 0}}
	value := strconv.Itoa(have_money)
	init := 4 - len(value)
	for i, v := range strings.Split(value, "") {
		v, _ := strconv.Atoi(v)
		if v > 5 {
			arr[init+i] = []int{1, v - 5}
		} else {
			arr[init+i] = []int{0, v}
		}
	}
	return arr
}
