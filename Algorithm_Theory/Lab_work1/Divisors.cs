using System;
using System.Collections.Generic;

class Program
{

    static List<ulong> printDivisors(ulong number)
    {
        List<ulong> divisors = new List<ulong>();

        for (ulong i = 1; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                divisors.Add(i);
                if (i != number / i)
                {
                    divisors.Add(number / i);
                }
            }
        }

        divisors.Sort();
        return divisors;
    }

    static void Main(string[] args)
    {
        string line = Console.ReadLine();
        ulong n = ulong.Parse(line);
        List<ulong> divisors = printDivisors(n);
        Console.WriteLine(string.Join(" ", divisors));
    }
}