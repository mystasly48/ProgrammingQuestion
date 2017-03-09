using System;
public class Program {
  public static void Main() {
    int b = int.Parse(Console.ReadLine());
    int N = int.Parse(Console.ReadLine());
    for (int i = 0; i < N; i++) {
      int p = int.Parse(Console.ReadLine());
      b -= p;
    }
    int five_thousand = b / 5000;
    b -= five_thousand * 5000;
    int one_thousand = b / 1000;
    b -= one_thousand * 1000;
    int five_hundred = b / 500;
    b -= five_hundred * 500;
    int one_hundred = b / 100;
    b -= one_hundred * 100;
    int fifteen = b / 50;
    b -= fifteen * 50;
    int ten = b / 10;
    b -= ten * 10;
    int five = b / 5;
    b -= five * 5;
    int one = b;
    Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7}", five_thousand, one_thousand, five_hundred, one_hundred, fifteen, ten, five, one);
  }
}
