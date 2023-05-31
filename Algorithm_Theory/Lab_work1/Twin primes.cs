using System;

class MyProgram
{
    static void printDivisors(ulong n)
    {
        ulong i, x = 0, sum = 0;
        for (i = n; i <= n * 2 - 2; i++)
        {
            if ((i % 2 != 0 && i % 3 != 0 && i % 5 != 0 && i % 9 != 0) || i == 2 || i == 3 || i == 5 || i == 7)
            {
                if (((i + 2) % 2 != 0 && (i + 2) % 3 != 0 && (i + 2) % 5 != 0 && (i + 2) % 9 != 0) || i+2 == 3 || i+2 == 5 || i+2 == 7)
                {
                    Console.Write("YES");
                    x = 1;
                    break;
                }
            }
        }
        if (x == 0)
            Console.Write("NO");
    }

    static void Main(string[] args)
    {
        string line = Console.ReadLine();
        ulong n = ulong.Parse(line);
        if (n == 1 || n == 2)
            Console.Write("NO");
        else
        {
            printDivisors(n);
        }

    }
}