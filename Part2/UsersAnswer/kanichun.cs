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
            int  input = int.Parse(Console.ReadLine());
            Random rand = new Random();
            int value = rand.Next(0, input);

            Console.WriteLine(value);
        }
    }
}
