using System;
using System.Linq;
public class Hello {
  public static void Main() {
    var values = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
    Console.WriteLine((int)((values[1] * 2 / values[2]) * values[3] / (values[0] + 1)));
  }
}