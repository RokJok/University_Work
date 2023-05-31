using System;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] things = new int[n];
        int[] loot = new int[n];
        string line = Console.ReadLine();
        var data = line.Split(' ');
        for (int i = 0; i < n; i++)
        {
            things[i] = int.Parse(data[i]);
        }
        if (n > 3)
        {
            int count = 0;
            int maxValue;
            loot[0] = things[0];
            loot[1] = Math.Max(things[0], things[1]);
            loot[2] = Math.Max(loot[1], things[2]);
            for (int i = 3; i < n; i++)
            {
                int temp = Math.Max(loot[i - 1], loot[i - 2]);
                loot[i] = Math.Max(temp, loot[i - 3] + things[i]);
            }
            maxValue = loot[n - 1];
            for (int j = 0; j < n; j++)
            {
                int temp2 = things[j];
                things[j] = 0;
                loot[0] = things[0];
                loot[1] = Math.Max(things[0], things[1]);
                loot[2] = Math.Max(loot[1], things[2]);
                for (int i = 3; i < n; i++)
                {
                    int temp1 = Math.Max(loot[i - 1], loot[i - 2]);
                    loot[i] = Math.Max(temp1, loot[i - 3] + things[i]);

                }
                if (loot[n - 1] != maxValue)
                {
                    things[j] = temp2;
                    count++;
                }
            }
            Console.WriteLine(maxValue);
            Console.WriteLine(count);
            int temp3 = 0;
            for (int i = 0; i < n; ++i)
            {
                if (things[i] != 0 && temp3 == 0)
                {
                    Console.Write(i + 1);
                    temp3++;
                }
                else if (things[i] != 0)
                    Console.Write(" " + (i + 1));

            }
        }
        else if (n == 3)
        {
            loot[0] = things[0];
            loot[1] = Math.Max(things[0], things[1]);
            loot[2] = Math.Max(loot[1], things[2]);
            int x = 0;
            while (loot[x] != loot[n - 1])
                x++;
            Console.WriteLine(loot[n - 1]);
            Console.WriteLine(1);
            Console.WriteLine(x+1);
        }
        else if (n == 2)
        {
            Console.WriteLine(Math.Max(things[0], things[1]));
            int x = 0;
            if (Math.Max(things[0], things[1]) != things[x])
                x++;
            Console.WriteLine(1);
            Console.WriteLine(x + 1);
        }
        else
        {
            Console.WriteLine(0);
            Console.WriteLine(0);
        }
    }
}