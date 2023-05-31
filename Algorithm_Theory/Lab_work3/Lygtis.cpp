#include <iostream>
#include <cmath>
#include <string>
#include <sstream>
#include <iomanip>

using namespace std;

int p, q, r, s, t, u;

double Function(double x)
{
    return p * exp(-x) + q * sin(x) + r * cos(x) + s * tan(x) + t * x * x + u;
}

double FunctionDerivative(double x)
{
    return -p * exp(-x) + q * cos(x) - r * sin(x) + s / pow(cos(x), 2) + 2 * t * x;
}

double NewtonRaphsonMethod()
{
    if (Function(0) == 0) return 0;

    for (double x = 0.5;;)
    {
        double x1 = x - Function(x) / FunctionDerivative(x);
        double EPS = 1e-8;
        if (abs(x1 - x) < EPS)
        {
            return x;
        }

        x = x1;
    }
}

int main() {
    
    ios_base::sync_with_stdio(false);
    cin.tie(NULL);
    while (cin >> p >> q >> r >> s >> t >> u)
    {
        if (Function(0) * Function(1) > 0) {
            cout << "No solution" << endl;
        }
        else {
            cout << fixed << setprecision(4) << NewtonRaphsonMethod() << endl;
        }
    }
}
