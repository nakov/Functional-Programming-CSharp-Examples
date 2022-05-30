using System;
using System.Linq;

internal class SortEvenNumbers
{
    static void Main()
    {
        Func<string, int> parseStringToInt = 
            x => int.Parse(x);

        Func<string, int, int, int, long> example =
            (name, x, y, speed) => x * y * speed;

        void Print(string s)
        {
            Console.WriteLine(s);
        }

        Action<string> print = Print;

        Func<int, bool> isEven = 
            x => x % 2 == 0;

        Func<int, int> identity = 
            n => n;

        string input = Console.ReadLine();
        string[] tokens = input.Split(", ");
        int[] nums = tokens.Select(parseStringToInt).ToArray();
        int[] evenNums = nums.Where(isEven).ToArray();
        int[] orderedEvenNums = evenNums.OrderBy(identity).ToArray();

        Console.WriteLine(String.Join(", ", orderedEvenNums));
    }
}
