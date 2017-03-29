using System;
public class Program {
  public static void Main() {
    const string Split = "----";
    int _N = int.Parse(Console.ReadLine());
    int _M = int.Parse(Console.ReadLine());
    int[] N = { _N % 10, _N / 10 };
    int[] M = { _M % 10, _M / 10 };
    Console.WriteLine("  {0}", _N);
    Console.WriteLine(" *{0}", _M);
    Console.WriteLine(Split);
    int a = M[0] * N[0] + M[0] * N[1] * 10;
    Console.WriteLine("{0, 4}", string.Format("{0:00}", a));
    int b = M[1] * N[0] + M[1] * N[1] * 10;
    Console.WriteLine("{0, 3} ", string.Format("{0:00}", b));
    Console.WriteLine(Split);
    int prod = a + b * 10;
    Console.WriteLine("{0, 4}", prod);
  }
}
