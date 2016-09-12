using System;
public class Program {
  public static void Main() {
    var length = int.Parse(Console.ReadLine());     // 入力を数値に変換して変数に代入（int型変数）
    var random = new Random().Next(0, length + 1);  // 0から入力された数値の間で乱数を生成（int型変数）
    Console.WriteLine(random);                      // 結果を出力する（int型変数）
  }
}
