using System;
public class Program {
  public static void Main() {
    var input = Console.ReadLine();
    var length = Convert.ToInt32(input);
    var rand = new Random();
    var result = rand.Next(0, length + 1);
    Console.WriteLine(result);
  }
}
