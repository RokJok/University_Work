#include <iostream>

using namespace std;

int main()
{
    std::ios_base::sync_with_stdio(false);
    std::cin.tie(0);
    std::cout.tie(0);

    int n, L, R;
    int j = 0;
    char com;

    cin >> n;
    long long* arr = new long long[n];
    for (int i = 0; i < n; i++)
    {
        cin >> com;
        if (com == '+')
        {
            cin >> arr[j];
            if (j != 0)
            {
                arr[j] += arr[j - 1];
            }
            j++;
        }
        else if (com == '?')
        {
            cin >> L >> R;
            if (L > 1 && L <= R)
            {
                cout << arr[R - 1] - arr[L - 2] << endl;
            }
            else if (L == R && L > 1 && R > 1)
            {
                cout << arr[R - 1] - arr[R - 2] << endl;
            }
            else
            {
                cout << arr[R - 1] << endl;
            }

        }

    }
    delete[] arr;
    return 0;
}