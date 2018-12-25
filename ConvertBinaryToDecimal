//Given a Binary Number B, Print its decimal equivalent.
//Do this for all test cases given in input

#include<iostream>
#include <vector>
#include <cmath>

using namespace std;

vector<int> GetDigitsOfNumber(unsigned long long int n)
    {
    vector<int> v;

    do
        {
        v.push_back(n%10);
        n = n / 10;
        } while (n > 0);

        //std::reverse(v.begin(), v.end());
        
        return v;
    }
    
int main()
 {
	//code
	int nTestCase = 0;
	cin >> nTestCase;
	
	for(int i = 0; i < nTestCase; ++i)
	{
  //Why n is chosen as unsigned long long int?
  //Refer https://stackoverflow.com/a/1819236/3193829
	unsigned long long int n = 0;
	cin >> n;
	
	vector<int> v = GetDigitsOfNumber(n);
	
	int size = v.size();
	int sum = 0;
	for(int i = 0; i < size; ++i)
	{
	    sum += pow(2, i)*v[i];
	}
	
	cout << sum << endl;
	}
	return 0;
}
