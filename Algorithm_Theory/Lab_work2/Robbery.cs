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
            loot[0] = things[0];
            loot[1] = Math.Max(things[0], things[1]);
            loot[2] = Math.Max(loot[1], things[2]);
            for (int i = 3; i < n; i++)
            {
                int temp = Math.Max(loot[i - 1], loot[i - 2]);
                loot[i] = Math.Max(temp, loot[i - 3] + things[i]);
            }
            Console.WriteLine(loot[n - 1]);
        }
        else if(n == 3)
        {
            loot[0] = things[0];
            loot[1] = Math.Max(things[0], things[1]);
            loot[2] = Math.Max(loot[1], things[2]);
            Console.WriteLine(loot[n - 1]);
        }
        else if (n == 2)
        {
            Console.WriteLine(Math.Max(things[0], things[1]));
        }
        else
            Console.WriteLine(0);
    }
}