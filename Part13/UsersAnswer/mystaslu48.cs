using System;
public class Program {
  public static void Main() {
    int balance = int.Parse(Console.ReadLine());
    int N = int.Parse(Console.ReadLine());
    for (int i = 0; i < N; i++) {
      int price = int.Parse(Console.ReadLine());
      balance -= price;
    }
    int[] money = { 5000, 1000, 500, 100, 50, 10, 5, 1 };
    int[] count = new [money.Length];
    for (int i = 0; i < counts.Length; i++) {
      count[i] = getCount(ref balance, money[i]);
    }
    Console.WriteLine(string.Join(" ", count));
  }

  private static int getCount(ref int balance, int coin) {
    int count = balance / coin;
    balance -= count * coin;
    return count;
  }
}
