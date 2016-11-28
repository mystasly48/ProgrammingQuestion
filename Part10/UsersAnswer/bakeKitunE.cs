using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var now = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var after = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        DateTime nowTime = new DateTime(now[0], now[1], now[2], now[3], now[4], now[5]);
        DateTime afterTime = new DateTime(after[0], after[1], after[2], after[3], after[4], after[5]);

        TimeSpan time = afterTime - nowTime;
        Console.WriteLine(Math.Ceiling(time.TotalHours));
    }
}
