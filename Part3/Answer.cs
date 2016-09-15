using System;
public class Program {
  public static void Main() {
    var count = int.Parse(Console.ReadLine());   // 入力を int に変換して変数に代入（int型変数）
    var sArray = Console.ReadLine().Split(' ');  // 入力をスペース区切りで配列に代入（string型配列）
    var dArray = new double[count];              // 商品価格を代入する変数を宣言（double型配列）
    for (int i = 0; i < count; i++)              // 入力された商品の個数でループ
      dArray[i] = double.Parse(sArray[i]);       // 商品価格を double に変換して代入（double型配列）
    const double TAX = 1.08;                            // 消費税を定義
    var result = 0;                              // 結果を代入する変数を宣言
    for (int i = 0; i < count; i++)              // 入力された商品の個数でループ
      result += (int)(dArray[i] * TAX);          // 商品価格に消費税をかけて、int に変換して代入。（int型変数）
    Console.WriteLine(result);                   // 結果を出力する（int型変数）
  }
}
