#include <iostream>

using namespace std;

int main()
{
    unsigned long long x, y, dbd = 1, a, b;
    cin >> x >> y;
    a = x;
    b = y;
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
            dbd = x;
            break;
        }
        if (x == 0)
        {
            dbd = y;
        }
        if (y == 0)
        {
            dbd = x;
        }
    }
    cout << a / dbd << " " << b / dbd;
    return 0;
}