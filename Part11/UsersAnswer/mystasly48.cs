using System;
using System.Linq;
using System.Collections.Generic;
public class Program {
  public static void Main() {
    int count = int.Parse(Console.ReadLine());
    int[] cards = Console.ReadLine().Split(' ').Select(int.Parse).OrderBy(x => x).ToArray();
    int[] distinctCards = cards.Distinct().ToArray();
    List<int> resultArray = new List<int>();
    foreach (int i in distinctCards) {
      int cardCount = cards.Count(x => x == i);
      if (cardCount % 2 != 0) {
        resultArray.Add(i);
      }
    }
    string result = (resultArray.Count != 0) ? string.Join(" ", resultArray) : "0";
    Console.WriteLine(result);
  }
}