using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 4; i++)
        {
            Console.ReadLine();
        }
        if (Console.ReadLine() == "ドコ")
        {
            Console.WriteLine("キヨシ！");
        }
        else
        {
            Console.WriteLine("ズコー！");
        }
    }
}
