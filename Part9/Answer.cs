using System;
public class Hello {
  public static void Main() {
    int count = int.Parse(Console.ReadLine());
    string[] input = Console.ReadLine().Split(' ');
    int min = int.MaxValue, max = int.MinValue;
    for (int i = 0; i < count; i++) {
      int j = int.Parse(input[i]);
      if (j < min) {
        min = j;
      }
      if (j > max) {
        max = j;
      }
    }
    Console.WriteLine("{0} {1}", min, max);
  }
}