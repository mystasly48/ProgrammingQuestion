using System;
using System.Linq;
public class Hello {
  public static void Main() {
    int count = int.Parse(Console.ReadLine());          // 入力を数値に変換
    char[] resultArray = new char[count];               // 結果直前の値を代入する配列を宣言
    Random rand = new Random();                         // 乱数生成のクラスをインスタンス化
    for (int i = 0; i < count; i++) {                   // count回ループする
      while (true) {                                    // 重複確認用の無限ループ
        int index = rand.Next(0, 26);                   // 1 ~ 25 の乱数を生成する
        char alphabet = (char)(index + 65);             // int の 65 を char に変換すると 半角大文字の A になるため、0 + 65 で A, 25 + 65 で Z になる
        if (!resultArray.Contains(alphabet)) {          // 取得したアルファベットが既に追加済みであればループ　追加済みでなければ下
          resultArray[i] = alphabet;                    // 配列に追加
          break;                                        // ループを抜ける
        }
      }
    }
    string result = string.Join(" ", resultArray);      // 配列の要素間にスペースを入れてstringに代入
    Console.WriteLine(result);                          // 結果を出力
  }
}