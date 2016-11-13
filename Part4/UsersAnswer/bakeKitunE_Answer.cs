using System;
using System.Linq;

namespace paiza
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int friend = input[0];          // 友達の人数
            int distance = input[1];        // 距離
            int fuel_economy = input[2];    // 燃費
            int fuel_price = input[3];      // 燃料の値段

            // 自分を含める
            int people = friend += 1;

            // 往復するため2倍に
            distance *= 2;

            // 往復するのに必要な燃料量
            double fuel = distance / fuel_economy;

            // 燃料を買う料金
            double price = fuel * fuel_price;

            // 割り勘
            // 小数点以下切り捨て
            int result = (int)price / people;

            Console.WriteLine(result);
        }
    }
}
