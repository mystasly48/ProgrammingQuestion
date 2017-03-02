import scala.util.Random

object Main extends App{
  var in = readLine().toInt
  var alfa = List("A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z")
  var random = new Random()
  var parsedAlfa = Random.shuffle(alfa)
  if (in == 26) in = 25
  for ( i <- 0 to in ) {
    print(parsedAlfa(i) + " ")
  }
}
