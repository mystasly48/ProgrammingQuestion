import scala.util.control.Breaks.{break, breakable}
import scala.math.ceil

object Main extends App{
  var wh = readLine().split(" ").map(_.toInt)
  var str = ""
  for ( i <- 0 to (wh(1)-1) ){
    str += readLine()
  }
  var coordinate = search(str)
  var y = askY(coordinate)
  var x = askX(y, wh, coordinate)
  println(x + " " + y)

  def search(str:String):Int={
    var trashValue = str(0)
    var s, v, cn = 0
    var c, h = '0'

    for ( value <- str ) {
      if (value == trashValue) {
        s += 1 
        c = value
      } else {
        v += 1
        h = value
      }
    }
    var search = if (s > v) h else c
    breakable{
      for ( value <- str ) {
        if (value != search){
          cn += 1
        } else {
          break
        }
      }
    }
    return(cn + 1)
  }
  def askY(coordinate:Int):Int={
    return ceil( coordinate / wh(1).toFloat ).toInt
  }
  def askX(yCoordinate:Int, wh:Array[Int], coordinate:Int):Int={
    var l = yCoordinate * wh(0)
    var f = l - (wh(0) -1)
    var count = 1
    breakable{
      for( i <- (f to l) ){
        if (coordinate != i) count += 1 else break
      }
    }
    return (count)
  }
}
