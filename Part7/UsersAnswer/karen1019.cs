using System;
using System.Threading;

namespace memotou {
  public class Program {
    static void Main() {
      string doko = "";
      for (int i = 0; i < 5; i++) {
        doko = Console.ReadLine();
      }
      string kiyosi = (doko == "ドコ") ? "キヨシ！" : "ズコー！";
        Console.WriteLine(kiyosi);
    }
  }
}
