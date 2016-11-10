using System;
public class Hello {
  public static void Main() {
    string[] input = Console.ReadLine().Split(' ');                 // 入力をスペースで分割して代入（string型配列）
    int count = int.Parse(input[0]) + 1;                            // 友達の人数に１（自分）を足した合計人数（int型変数）
    int consumed = int.Parse(input[1]) * 2 / int.Parse(input[2]);   // 距離を倍にして（往復分）燃費で割った消費ガソリン（int型変数）
    int cost = consumed * int.Parse(input[3]);                      // 消費したガソリンとガソリンの値段をかけた合計金額（int型変数）
    int result = cost / count;                                      // 合計金額を合計人数で割った１人あたりの金額（int型変数）
    Console.WriteLine(result);                                      // １人あたりの金額を出力
  }
}

