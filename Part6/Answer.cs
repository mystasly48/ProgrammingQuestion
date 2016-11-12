using System;
public class Hello {
  public static void Main() {
    string s = Console.ReadLine();   // 文字列(s) を代入
    string c = Console.ReadLine();   // 文字(c) を代入（char変数に代入しても良かったが、不要と判断）
    bool result = s.Contains(c);     // s に c が含まれているか
    Console.WriteLine(result;        // 結果を出力
  }
}