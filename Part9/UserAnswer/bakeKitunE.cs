using System;
using System.Linq;

public class Test
{
    public static void Main()
    {
        Console.ReadLine();
        var intAry = Console.ReadLine().Split(' ').Select(int.Parse);
        Console.WriteLine("{0} {1}", intAry.Min(), intAry.Max());
    }
}