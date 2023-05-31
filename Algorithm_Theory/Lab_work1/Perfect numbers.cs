using System;

class MyProgram
{
    static void printDivisors(ulong n)
    {
        ulong i, x = 0, sum = 0;
        for (i = 1; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                sum += i;
                x = i;
            }
            if (n / i == i)
            {
                i--;
                break;
            }
        }
        if (n / i == x)
            i--;
        for (; i > 1; i--)
        {
            if (n % i == 0)   
            {
                sum += n / i;
            }
           
        }
        if (sum == n)
            Console.Write("TAIP");
        else
            Console.Write("NE");
    }

    static void Main(string[] args)
    {
        string line = Console.ReadLine();
        ulong n = ulong.Parse(line);
        if (n == 1)
            Console.Write("NE");
        else
            printDivisors(n);
    }
}