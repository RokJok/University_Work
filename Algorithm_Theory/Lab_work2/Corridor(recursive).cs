using System;

class Program
{
    static long CountWays(int m, int n, int x, long[] ways)
    {
        if(ways[n-1] != 0)
        {
            return ways[n-1];
        }
        ways[n-1] = CountWays(m, n - 1, x, ways) + CountWays(m, n - 2 - x, x, ways);
        return ways[n - 1];
    }

    static void Main(string[] args)
    {
        var line = Console.ReadLine();
        var data = line.Split(' ');
        int m = int.Parse(data[0]);
        int n = int.Parse(data[1]);
        int x = m > 2 ? m - 2 : 0;
        
        if (m <= n)
        {
            long[] ways = new long[n];
            for(int i = 0; i < m; i++)
            {
                    ways[i] = 1;
            }
            ways[m - 1] = 2;
            Console.WriteLine(CountWays(m, n, x, ways));
        }
        else
            Console.WriteLine(1);
    }
}