//calculate nPr which represents n permutation r and value of nPr is (n!) / (n-r)!

#include<iostream>
using namespace std;
unsigned long long int CalculateFactorial(int n)
    {
    unsigned long long int fact = 1;
    for (int i = 1; i < n + 1; ++i)
        {
        fact *= i;
        }
    return fact;
    }

int main()
    {
    //code
    int nTestCase = 0;
    cin >> nTestCase;

    for (int i = 0; i < nTestCase; ++i)
        {
    int n = 1, r = 1;
    cin >> n; cin >> r;
    unsigned long long int fact1 = CalculateFactorial(n);
    unsigned long long int fact2 = CalculateFactorial(n-r);
        cout << fact1/fact2 << endl;
        }
    return 0;
    }
