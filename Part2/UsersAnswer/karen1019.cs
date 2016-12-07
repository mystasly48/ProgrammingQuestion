using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memotou {
  class Program {
    static void Main(string[] args) {
      string str_input = Console.ReadLine();
      int int_input = int.Parse(str_input);
      Random cRandom = new System.Random();
      Console.WriteLine(cRandom.Next(int_input + 1));
    }
  }
}
