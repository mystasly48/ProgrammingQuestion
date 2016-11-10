using System;
using System.Linq;

public class Answer01
{
    public static void Main()
    {
        Console.WriteLine(Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray().Sum());
    }
}