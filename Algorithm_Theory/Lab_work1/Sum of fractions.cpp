#include <iostream>

using namespace std;


long long DBD(long long x, long long y)
{
    while (x != 0 && y != 0)
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
            return x;
        }
        if (x == 0)
        {
            return y;
        }
        if (y == 0)
        {
            return x;
        }
    }
    return 0;
}

int main()
{
    long long a, b, c, d, dbd, mbk;
    cin >> a >> b >> c >> d;
    if (b != d)
    {
        dbd = DBD(b, d);
        mbk = (b * d) / dbd;
        a = a * (mbk / b);
        c = c * (mbk / d);
        b = mbk;
    }
    
    a += c;
    dbd = DBD(a, b);
    cout << a / dbd << " " << b / dbd;
    return 0;
}