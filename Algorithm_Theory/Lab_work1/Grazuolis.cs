using System;
using System.Collections.Generic;

class Program
{

    static bool GetDivisors(ulong number)
    {
        int lyg = 0, nel = 0;
        for (ulong i = 1; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                if (i % 2 == 0)
                    lyg++;
                else
                    nel++;
                if (i != number / i)
                {
                    if (number / i % 2 == 0)
                        lyg++;
                    else
                        nel++;
                }
            }
        }
        if (lyg == nel)
            return true;
        else
            return false;
    }

    static void Main(string[] args)
    {
        string line = Console.ReadLine();
        ulong n = ulong.Parse(line);
        if (GetDivisors(n) == true)
            Console.Write("TAIP");
        else
            Console.Write("NE");
    }
}