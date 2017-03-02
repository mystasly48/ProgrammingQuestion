import scala.math.floor

object Main extends App{
  var in = readLine().split(" ").map(_.toInt)
  var useEnergy     = (in(1) * 2).toFloat / in(2)
  var amountOfMoney = useEnergy * in(3)
  var splitAmount   = amountOfMoney / (in(0) + 1)
  println(floor(splitAmount).toInt)
}
