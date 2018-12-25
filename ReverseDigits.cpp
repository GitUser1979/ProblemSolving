//Reverse digits of a number N

#include<iostream>
#include <vector>
#include <cmath>
#include<algorithm>
using namespace std;

vector<int> GetDigitsOfNumber(unsigned long long int n)
    {
    vector<int> v;

    do
        {
        v.push_back(n % 10);
        n = n / 10;
        } while (n > 0);

        std::reverse(v.begin(), v.end());

        return v;
    }

int main()
    {
    //code
    int nTestCase = 0;
    cin >> nTestCase;

    for (int i = 0; i < nTestCase; ++i)
        {
        unsigned long long int n = 200;
        cin >> n;

        vector<int> v = GetDigitsOfNumber(n);

        int size = v.size();
        unsigned long long int sum = 0;
        for (int i = 0; i < size; ++i)
            {
            sum += pow(10, i)*v[i];
            }

        cout << sum << endl;
        }

    return 0;
    }
