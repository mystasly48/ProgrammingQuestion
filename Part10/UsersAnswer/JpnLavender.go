package main

import (
	"bufio"
	"fmt"
	"os"
	"strings"
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

func time_parse(time string) string {
	t := strings.Split(time, " ")
	date := []string{t[0], t[1], t[2]}
	timee := []string{t[3], t[4], t[5]}
	parsed_date := strings.Join(date, "-")
	parsed_time := strings.Join(timee, ":")
	return parsed_date + " " + parsed_time + " " + "JST"
}

func time_processing(time_1 string, time_2 string) time.Duration {
	t1, _ := time.Parse("2006-01-02 15:04:05 MST", time_parse(time_1))
	t2, _ := time.Parse("2006-01-02 15:04:05 MST", time_parse(time_2))
	return t2.Sub(t1)
}

func main() {
	time_1 := gets()
	time_2 := gets()
	answer := time_processing(time_1, time_2)
	fmt.Println(answer)
}
