#include <iostream>
#include <list>
#include <math.h>

using namespace std;


    long long FindGCD(long long a, long long q)
    {
        int x = a;
        int y = q;
        int GCD = -1;
        while (x != 0 || y != 0)
        {
            if (x < y)
            {
                y %= x;
            }
            else if (y < x)
            {
                x %= y;
            }
            else if (x == y)
            {
                GCD = x;
                break;
            }
            if (x == 0)
            {
                GCD = y;
                break;
            }
            if (y == 0)
            {
                GCD = x;
                break;
            }
        }
        return GCD;
    }
    
    void FindDivisors(long long p, long long q)
    {
        list<long long> B;
        for (long long i = 1; i <= sqrt(p); i++)
        {
            if (p % i == 0)
            {
                B.push_back(i);
                if (i != p / i)
                {
                    B.push_back(p / i);
                }
            }
        }
        B.sort();
        int sum = 0;
        while (B.size() > 0)
        {
            long long x = B.front();
            B.pop_front();
            long long GCD = FindGCD(x, q);
            if (GCD == 1)
            {
                if (sum > 0)
                    cout << " ";
                cout << x;
                sum++;
            }
       }
        if (sum == 0)
            cout << 0;
    }

    int main()
    {
        long long p, q;
        cin >> p >> q;
        FindDivisors(p, q);
        return 0;
    }