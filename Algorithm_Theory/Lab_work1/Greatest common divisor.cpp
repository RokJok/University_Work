#include <iostream>

using namespace std;

int main()
{
    int n;
    cin >> n;
    long long x, y;

    for (int i = 1; i <= n; i++)
    {
        cin >> x >> y;
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
                cout << x;
                break;
            }
            if (x == 0)
            {
                cout << y;
                break;
            }
            if (y == 0)
            {
                cout << x;
                break;
            }
        }
        if (i != n)
            cout << endl;
    }
    return 0;
}