package main

import(
    "fmt"
    "os"
    "bufio"
    "strconv"
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
    alphabets  := []string{"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"}
    return alphabets
}

func main(){
    var dick int = gets()
    test := createAlphabetList()
    test[0]
    fmt.Println(dick)
}
