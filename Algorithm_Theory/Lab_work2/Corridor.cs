using System;

class Program
{
    static void Main(string[] args)
    {
        int n, m, x;
        var line = Console.ReadLine();
        var data = line.Split(' ');
        m = int.Parse(data[0]);
        n = int.Parse(data[1]);

        if (m <= n)
        {
            long[] ways = new long[n];
            Array.Fill(ways, 1);
            ways[m - 1] = 2;

            if (m > 2)
                x = m - 2;
            else
                x = 0;


            for (int i = m; i < n; i++)
            {
                ways[i] = ways[i - 1] + ways[i - 2 - x];
            }
            Console.WriteLine(ways[n - 1]);
        }
        else
            Console.WriteLine(1);

    }
}