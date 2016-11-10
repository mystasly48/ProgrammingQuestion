using System;
using System.Linq;

namespace Answer
{
    public class Answer
    {
        public static void Main()
        {
            // 入力された値の消費税込みの値を出力
            Console.WriteLine(Console.ReadLine().Split(' ').Select(int.Parse).ToArray().Sum() * 1.08);
        }
    }
}