
#include "pch.h"
#include <iostream>
#include <vector>
#include <string>
using namespace std;

//Calculate the nth term of an Arithmatic Progression, given the first two terms
int GetNthTermInAP()
    {
    //code
    vector<int> v;
    int numTestCases = 0;
    cin >> numTestCases;

    for (int i = 0; i < numTestCases; ++i)
        {
        int A = 0;
        cin >> A;

        int B = 0;
        cin >> B;


        int CD = B - A;
        int n;
        cin >> n;
        int num = A + (n - 1)*CD;
        cout << num << endl;

        }
    return 0;
    }

//For a given 3 digit number, find whether it is armstrong number or not. 
//An Armstrong number of three digits is an integer such that the sum of the 
//cubes of its digits is equal to the number itself. 
//For example, 371 is an Armstrong number since 33 + 73 + 13 = 371
int CheckArmstrongNumber()
    {
    //code
    int nTestCase = 1;
    cin >> nTestCase;

    for (int i = 0; i < nTestCase; ++i)
        {
        int n = 0;
        cin >> n;

        int OnethDigit = n % 10;
        int TenthDigit = (n / 10) % 10;
        int HundredthDigit = ((n / 10) / 10);

        if (((OnethDigit*OnethDigit*OnethDigit) + (TenthDigit*TenthDigit*TenthDigit) + (HundredthDigit*HundredthDigit*HundredthDigit)) == n)
            {
            cout << "Yes" << endl;
            }
        else
            cout << "No" << endl;
        }
    return 0;
    }