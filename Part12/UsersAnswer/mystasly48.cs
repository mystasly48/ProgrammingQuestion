using System;
public class Program {
  public static void Main() {
    string[] input = Console.ReadLine().Split(' ');
    int W = int.Parse(input[0]);
    int H = int.Parse(input[1]);
    string[][] map = new string[H][];
    for (int i = 0; i < H; i++) {
      map[i] = new string[W];
      string input2 = Console.ReadLine();
      for (int j = 0; j < W; j++) {
        map[i][j] = input2[j].ToString();
      }
    }

    int a_count = 0, b_count = 0;
    string a = "", b = "";
    string a_pos = "", b_pos = "";
    for (int i = 0; i < H; i++) {
      for (int j = 0; j < W; j++) {
        string s = map[i][j];
        if (a == "") {
          a = s;
          a_count++;
          a_pos = string.Format("{0} {1}", j+1, i+1);
        } else if (a == s) {
          a_count++;
          a_pos = string.Format("{0} {1}", j+1, i+1);
        } else if (b == "") {
          b = s;
          b_count++;
          b_pos = string.Format("{0} {1}", j+1, i+1);
        } else if (b == s) {
          b_count++;
          b_pos = string.Format("{0} {1}", j+1, i+1);
        }
      }
    }

    string pos = (a_count < b_count) ? a_pos : b_pos;
    Console.WriteLine(pos);
  }
}
