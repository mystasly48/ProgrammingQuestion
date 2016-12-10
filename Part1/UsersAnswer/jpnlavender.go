package main

import(
    "fmt"
    "os"
    "bufio"
    "strings"
    "strconv"
)

var input = bufio.NewScanner(os.Stdin)

func gets() string {
    if input.Scan() {
        return input.Text()
    } else {
        return "NotInputData"
    }
}

func calculation(inputValue []string) int {
    var result int
    for i := 0; i < len(inputValue); i++ {
        i, _ := strconv.Atoi(inputValue[i])
        result += i
    }
    return result
}

func main() {
    inputValue := strings.Split(gets(), " ")
    anwer := calculation(inputValue)
    fmt.Println(anwer)
}

