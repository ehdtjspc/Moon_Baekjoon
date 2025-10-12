#include<bits/stdc++.h>

using namespace std;


int a , b;
string c , d;

int main()
{
  
  cin >> a;
  while(a--)
  {
  	map<string,int> _map;	
  	cin >> b;
  	for(int i = 0; i<b; i++)
  	{
  		cin >> c >> d;
  		_map[d]++;
	}
	long long ret = 1;
	for(auto c : _map)
	{
		ret *= ((long long)c.second + 1);
	}
	ret--;
	cout << ret << "\n";
  }
	return 0;
}