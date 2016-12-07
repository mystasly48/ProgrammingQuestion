using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int sum = 0;
            foreach(string item in input)
            {
                sum =sum + int.Parse(item);
                
            }
            Console.WriteLine(sum);
        }
    }
}
