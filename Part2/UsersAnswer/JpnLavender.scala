import scala.util.Random

object Main extends App{
  var in = readLine().toInt
  val rand = new Random
  println( rand.nextInt(in) )
}
