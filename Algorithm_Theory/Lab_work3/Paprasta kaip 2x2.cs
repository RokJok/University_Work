using System;

public class Program
{
    public static void Main()
    {
        double d;
        var line = Console.ReadLine();
        d = double.Parse(line);
        if (d == 4)
            Console.WriteLine("{0:F9} {1:F9}", 2, 2);
        else
        {
            double a = BinarySearchA(d);
            double b;
            if (a == 0)
            {
                b = 0;
            }
            else
                b = d / a;
            if (Math.Abs(d - (a + b)) > 1e-9)
            {
                Console.WriteLine("NERA");
            }
            else
            {
                Console.WriteLine("{0:F9} {1:F9}", a, b);
            }
        }
    }

    public static double BinarySearchA(double d)
    {
        double low = 0.0;
        double high = d;

        while (high - low >= 1e-12)
        {
            double mid = (low + high) / 2.0;
            double x = mid * (d - mid);
            if (x < d)
            {
                low = mid;
            }
            else
            {
                high = mid;
            }
        }

        return (low + high) / 2.0;
    }

}