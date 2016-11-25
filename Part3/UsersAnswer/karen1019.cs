using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memotou {
  class Program {
    static void Main(string[] args) {
      double dou_answer = 0;
      string str_input1 = Console.ReadLine();
      string str_input2 = Console.ReadLine();
      int int_input1 = int.Parse(str_input1);
      string[] arr = str_input2.Split(' ');
      for (int i = 0; i < int_input1; i++) {
        dou_answer += int.Parse(arr[i]);
      }
      dou_answer = dou_answer * 1.08;
      double answer = Math.Floor(dou_answer);
      Console.WriteLine(dou_answer);
    }
  }
}
