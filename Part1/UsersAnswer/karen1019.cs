using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memotou {
  class Program {
    static void Main(string[] args) {
      int answer = 0;
      string input = Console.ReadLine();
      string[] arr = input.Split(' ');
      for (int i = 0; i < arr.Length; i++) {
        answer += int.Parse(arr[i]);
      }
      Console.WriteLine(answer);
    }
  }
}
