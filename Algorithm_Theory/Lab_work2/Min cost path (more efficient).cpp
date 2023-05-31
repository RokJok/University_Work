#include <iostream>
#include <vector>
#include <sstream>
#include <algorithm>

using namespace std;

int main() {
    int n, m;
    string line;
    getline(cin, line);
    stringstream ss(line);
    ss >> n >> m;
    vector<int> MinSum(m);
    for (int i = 0; i < n; i++) {
        getline(cin, line);
        stringstream ss(line);
        for (int j = 0; j < m; j++) {
            int temp;
            ss >> temp;
            if (i == 0 && j == 0)
                MinSum[j] = temp;
            else if (i == 0)
                MinSum[j] = temp + MinSum[j - 1];
            else if (j == 0)
                MinSum[j] = temp + MinSum[0];
            else
                MinSum[j] = min(temp + MinSum[j - 1], temp + MinSum[j]);
        }
    }
    cout << MinSum[m - 1] << endl;
    MinSum.clear();
    return 0;
}
