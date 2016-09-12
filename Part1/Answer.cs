using System;
public class Program {
  public static void Main() {
    var str = Console.ReadLine(); // 入力を変数に代入（string型変数）
    var array = str.Split(' ');   // スペースで分割して配列に代入（string型変数からstring型配列）
    var result = 0;               // 足し算していく変数を宣言（int型変数）
    foreach (var s in array)      // 配列の内容を毎度 s に代入してループ（string型配列からstring型変数）
      result += int.Parse(s);     // 配列の内容を数値に変換して結果に足す（string型変数からint型変数）
    Console.WriteLine(result);    // 結果を出力する（int型変数）
  }
}
