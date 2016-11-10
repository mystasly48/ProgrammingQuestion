using System;

public class Answer01
{
    public static void Main()
    {
        // 入力された値の中で乱数を作る
        Console.WriteLine(new Random().Next(int.Parse(Console.ReadLine())));
    }
}