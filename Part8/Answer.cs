using System;
using System.Collections.Generic;
public class Program {
  public static void Main() {
    string s = Console.ReadLine();
    string t = Console.ReadLine();
    List<char> sList = new List<char>();
    List<char> tList = new List<char>();
    for (int i = 0; i < s.Length; i++) {
      char c = s[i];
      if (sList.IndexOf(c) == -1) {
        sList.Add(c);
      }
    }
    for (int i = 0; i < t.Length; i++) {
      char c = t[i];
      if (tList.IndexOf(c) == -1) {
        tList.Add(c);
      }
    }
    int result = 0;
    for (int i = 0; i < sList.Count; i++) {
      if (tList.IndexOf(sList[i]) != -1) {
        result++;
      }
    }
    Console.WriteLine(result);
  }
}