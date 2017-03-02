object Main extends App{
  var n = readLine()
  var i = readLine().split(" ").map(_.toInt)
  print (i.min + " " + i.max)
}
