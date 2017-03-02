import scala.math.floor

object Main extends App{
  var in = readLine().toInt
  var price = readLine().split(" ").map(_.toInt)
  var answer_value = 0
  for ( i <- price ) {
    answer_value += i
  }
  println( floor(answer_value * 1.08).toInt )
}
