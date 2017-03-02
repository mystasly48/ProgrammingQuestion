object Main extends App{
  var in = readLine().split(" ").map(_.toInt)
  var answer_value = 0
  for( i <- in ){
    answer_value += i
  }
  println(answer_value)
}
