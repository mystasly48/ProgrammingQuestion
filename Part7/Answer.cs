using System;
public class Hello {
  public static void Main() {
    for (int i = 0; i < 5; i++) {        // ５回ループ
      if (i == 4) {                      // ５回目のループ
        string t = Console.ReadLine();   // ５行目が入力される
        if (t == "ドコ") {                 // 「ドコ」と入力された
          Console.WriteLine("キヨシ！");     // 「キヨシ！」と出力
        } else {                         // その他が入力された
          Console.WriteLine("ズコー！");     // 「ズコー！」と出力
        }
      } else {
        Console.ReadLine();              // 無視
      }
    }
  }
}