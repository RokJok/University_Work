#include <iostream>
#include <list>
#include <math.h>

    using namespace std;


    list<int> FindDivisors( int x)
    {
        list<int> B;
        for (int i = 1; i <= sqrt(x); i++)
        {
            if (x % i == 0)
            {
                B.push_back(i);
                if (i != x / i)
                {
                    B.push_back(x / i);
                }
            }
        }
        B.sort();
        B.pop_back();
        B.pop_front();
        return B;
    }
    
    void FindX(int n, list <int> A)
    {
      
        int x = A.front() * A.back();
        
        list <int> B = FindDivisors(x);
        if ((A.size() - B.size()))
        {
            cout << -1;
        }
        else
        {
            while(A.size() > 0)
            {
                if (x % A.front() != 0)
                {
                    cout << -1;
                    break;
                }
                else
                    A.pop_front();
                if(A.size() == 0)
                    cout << x;
            }
        }
    }

    

    int main()
    {
        list<int> A;
        int n;
        cin >> n;
        for (int i = 0; i < n; i++)
        {
            int x;
            cin >> x;
            A.push_back(x);
        }
        A.sort();
        if (n == 1)
        {
            int x = A.front() * A.front();
            list <int> B = FindDivisors(x);
            if (B.size() == 1)
                cout << A.front() * A.front();
            else
                cout << -1;
        }  
        else if (n == 2)
        {
            int x = A.front() * A.back();
            list <int> B = FindDivisors(x);
            if (B.size() == 2)
                cout << A.front() * A.back();
            else
                cout << -1;
        }
        else
            FindX(n, A);
        return 0;
    }
