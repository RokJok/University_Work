using System;
using System.Collections.Generic;
using System.Linq;

namespace ProcessIDs
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong p,q;
            string[] line = Console.ReadLine().Split(' ');
            p = ulong.Parse(line[0]);
            q = ulong.Parse(line[1]);
            List<ulong> Fractions = new List<ulong>();

            EgyptianFraction(p, q, Fractions);

            Console.WriteLine(Fractions.Count);

            for(int i = 0; i < Fractions.Count; i++)
            {
                Console.Write("1/{0}", Fractions[i]);
                if(i != Fractions.Count - 1)
                    Console.Write(' ');
            }
        }

        static void EgyptianFraction(ulong p, ulong q, List<ulong> Fractions)
        {
            ulong GCD = ReduceFraction(p, q);
            p = p / GCD;
            q = q / GCD;
            if(q % p == 0)
            {
                Fractions.Add(q / p);
                return;
            }
            else if(p > q)
            {
                Fractions.Add(p / q);
                EgyptianFraction(p % q, q,Fractions);
                return;
            }
            ulong n = q / p + 1;
            Fractions.Add(n);
            EgyptianFraction(p * n - q, q * n,Fractions);
        }
        static ulong ReduceFraction(ulong p, ulong q)
        {
            ulong a = p;
            ulong b = q;
            ulong GCD = 1;
            while(a != 0 && b != 0)
            {
                if (a < b)
                {
                    b %= a;
                }
                else if (b < a)
                {
                    a %= b;
                }
                else if (a == b)
                {
                    GCD = a;
                    break;
                }
                if (a == 0)
                {
                    GCD = b;
                }
                if (b == 0)
                {
                    GCD = a;
                }
            }
            return GCD;
        }
    }
}