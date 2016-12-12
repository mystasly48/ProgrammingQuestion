package main
import(
    "fmt"
    "os"
    "bufio"
    "strconv"
    "strings"
    "math"
)

var input = bufio.NewScanner(os.Stdin)

func main() {
    _ := gets()
    parseValues := valueSplitParse(gets())
    answer := comparison(parseValues)
    fmt.Println(answer[0], answer[1])
}

func comparison(parseValues []int ) []int {
    var result []int
    max := math.SmallestNonzeroFloat64
    min := math.MaxFloat64
    for _, n := range parseValues {
        if float64(n) > max {
			max = float64(n)
		}
		if float64(n) < min {
			min = float64(n)
		}
    }

    result = append( result, int(min) )
    result = append( result, int(max) )
    return result
}

func valueSplitParse( inputValue string ) []int{
    valueSplit := strings.Split(inputValue, " ")
    var result []int
    for _, v := range valueSplit {
        iv, _ := strconv.Atoi(v)
        result = append(result, iv)
    }
    return result
}

func gets() string {
    if input.Scan() {
        return input.Text()
    } else {
        return "NoInputData"
    }
}
