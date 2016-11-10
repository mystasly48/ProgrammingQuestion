using System;
using System.Linq;
public class Hello {
  public static void Main() {
    var values = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    Console.WriteLine((values[1] * 2 / values[2]) * values[3] / (values[0] + 1));
  }
}