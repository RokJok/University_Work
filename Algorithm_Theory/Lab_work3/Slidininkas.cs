using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int t = int.Parse(Console.ReadLine());
        for (int i = 0; i < t; i++)
        {
            string path = Console.ReadLine();
            Console.WriteLine(Time(path));
        }
    }

    static int Time(string path)
    {
        HashSet<string> Visited = new HashSet<string>();
        int time = 0;
        int x = 0, y = 0;

        for (int i = 0; i < path.Length; i++)
        {
            int prevX = x;
            int prevY = y;

            if (path[i] == 'S')
                y--;
            else if (path[i] == 'N')
                y++;
            else if (path[i] == 'W')
                x--;
            else if (path[i] == 'E')
                x++;

            string segment = $"{prevX},{prevY},{x},{y}";
            string segmentRev = $"{x},{y},{prevX},{prevY}";

            if (Visited.Contains(segment) || Visited.Contains(segmentRev))
            {
                time += 1;
            }
            else
            {
                Visited.Add(segment);
                time += 5;
            }
        }

        return time;
    }
}