using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var s = Console.ReadLine().ToArray();
        var t = Console.ReadLine().ToArray();
        int count = 0;

        count = s.Intersect(t).Count();

        Console.WriteLine(count);
    }
}
