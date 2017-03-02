object Main extends App{
  var i = readLine()
  var n = readLine.split(" ").map(_.toInt)
  var min, max = n(0) 
  for( i <- 0 to (n.length-1) ){
    if (n(i) <= min){
      min = n(i)
    }
    if (n(i) >= max){
      max = n(i)
    }
  }
  println(min + " " + max)
}
