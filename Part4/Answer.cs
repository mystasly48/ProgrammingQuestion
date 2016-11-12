using System;
public class Hello {
  public static void Main() {
    string[] input = Console.ReadLine().Split(' ');                          // 入力をスペースで分割して代入
    double count = double.Parse(input[0]) + 1;                               // 友達の人数に１（自分）を足した合計人数
    double consumed = double.Parse(input[1]) * 2 / double.Parse(input[2]);   // 距離を倍にして（往復分）燃費で割った消費ガソリン
    double cost = consumed * double.Parse(input[3]);                         // 消費したガソリンとガソリンの値段をかけた合計金額
    double result = cost / count;                                            // 合計金額を合計人数で割った１人あたりの金額
    Console.WriteLine((int)result);                                          // １人あたりの金額を切り捨てて出力
  }
}

