#include <bits/stdc++.h>

using namespace std;

// Complete the beautifulBinaryString function below.
int beautifulBinaryString(string b) {

const char* str = b.c_str();

int n = b.length();

int ans = 0;
for(int i = 0; i < n; ++i)
{
    if(str[i] == '0' && str[i+1] == '1' && str[i+2] == '0' )
    {
    b[i+2] = '1';
    ans++;
    }
}

return ans;

}

int main()
{
    ofstream fout(getenv("OUTPUT_PATH"));

    int n;
    cin >> n;
    cin.ignore(numeric_limits<streamsize>::max(), '\n');

    string b;
    getline(cin, b);

    int result = beautifulBinaryString(b);

    fout << result << "\n";

    fout.close();

    return 0;
}
