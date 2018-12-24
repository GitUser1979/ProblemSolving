//Check whether sum of digits for an input number is Palindrome or not?	
//The number should be <= 1000	
//e.g. if 56 is passed as input number, then sum of its digits id 11 which is a palindrome.	
#include<iostream>
#include<vector>
#include<numeric>
#include<algorithm>
using namespace std;

//for n <= 1000
std::vector<int> GetDigitsOfNumber(int n)
    {
    std::vector<int> v;

    do
        {
        v.push_back(n%10);
        n = n / 10;
        } while (n > 0);

        std::reverse(v.begin(), v.end());
        
        return v;
    }
    
    std::string CheckForPalindromeNumber(std::vector<int> v)
    {
    int size = v.size();
   
    for (int i = 0; i < v.size(); ++i)
        {
        if (v[i] != v[size - 1 - i])
            {
            return "NO";
            }
        }
   
    return "YES";
    }
    
    int SumElementsOfVector(std::vector<int> v)
    {   
    return std::accumulate(v.begin(), v.end(), 0);
    }

int main()
 {
	//code
	int nTestCase = 0;
	cin >> nTestCase;
	for(int i = 0; i < nTestCase; ++i)
	{
	int n = 0;
	cin >> n;
	std::vector<int> v = GetDigitsOfNumber(n);
	int sum = SumElementsOfVector(v);
	std::vector<int> v1 = GetDigitsOfNumber(sum);
	std::string result = CheckForPalindromeNumber(v1);
	cout << result << endl;
	}
	
	return 0;
}
