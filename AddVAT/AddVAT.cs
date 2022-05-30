using System;
using System.Linq;

internal class AddVAT
{
    static void Main()
    {
        Func<decimal, decimal> addVAT = x => x * 1.20m;

        string input = Console.ReadLine(); 
        string[] tokens = input.Split(", ");
        decimal[] nums = tokens.Select(decimal.Parse).ToArray();
        decimal[] numsWithVAT = nums.Select(addVAT).ToArray();

        //foreach (var n in numsWithVAT)
        //{
        //    Console.WriteLine("{0:f2}", n);
        //}
        
        Array.ForEach(numsWithVAT, x => Console.WriteLine("{0:f2}", x));
    }
}

