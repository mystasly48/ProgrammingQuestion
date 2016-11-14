using System;
using System.Linq;

public class Test
{
    public static void Main()
    {
        int count;

        int.TryParse(Console.ReadLine(), out count);

        if (count <= 26)
        {
            string result = ShuffleString("ABCDEFGHIJKLMNOPQRSTUVWXYZ");

            var resultArray = result.ToArray();

            for (int i = 0; i < count; i++)
            {
                Console.Write(resultArray[i] + " ");
            }
        }
        
        Console.Write("\n");
    }

    // 文字列をシャッフルする
    public static string ShuffleString(string str)
    {
        var strArray = str.ToArray();

        var strShuffle = strArray.OrderBy(i => Guid.NewGuid()).ToArray();

        string result = "";

        foreach (var item in strShuffle)
        {
            result += item.ToString();
        }

        return result;
    }
}