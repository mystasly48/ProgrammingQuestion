using System;
using System.Linq;
public class Program {
  public static void Main() {
    int n = int.Parse(Console.ReadLine());
    int[][] points = new int[n][];
    for (int i = 0; i < n; i++) {
      points[i] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    }
    Console.WriteLine(
      string.Join(Environment.NewLine, 
        points.OrderBy(p => distance(p[0], p[1])).Select(p => $"{p[0]} {p[1]}")
      )
    );
  }
  
  // 原点との直線距離（ユークリッド距離）を求める
  public static double distance(int x, int y) {
    return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
  }
}
