package main

import(
    "fmt"
    "os"
    "bufio"
    "time"
    "strconv"
    "strings"
    "math/rand"
)

var input = bufio.NewScanner(os.Stdin)

func gets() int {
    if input.Scan() {
        var result int
        result, _ = strconv.Atoi(input.Text())
        return result
    }else {
        return 404
    }
}

func createAlphabetList() []string {
    alphabets  := []string{"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"}
    return alphabets
}

func createAnswrValue(countNum int , alphabets []string) []string {
    var result []string
    for {
        newAlphabet := sample(alphabets)
        if include(result, newAlphabet) {
            continue
        } else {
            result = append(result, newAlphabet)
            if len(result) >= countNum {break}
        }
    }
    return result
}

func changer (answerValue []string) string {
    return strings.Join(answerValue, " ")
}

func sample(s []string) string {
    rand.Seed(time.Now().UnixNano())
    i := rand.Intn(len(s))
    return s[i]
}

func include( ary []string, findValue string ) bool {
    for _, value := range ary {
        if value == findValue {return true}
    }
    return false
}

func main(){
    var dick int = gets()
    answerValue := createAnswrValue(dick, createAlphabetList())
    answer := changer(answerValue)
    fmt.Println(answer)
}
