
#include <iostream>
using namespace std;




int main()
{



	int a[9] = {};

	for (int i = 0; i <9; i++)
	{
		cin >> a[i];
    }

	int max = -1;
	int maxIndex;
	for (int i = 0; i < 9; i++)
	{
		if (a[i] > max)
		{
			max = a[i];
			maxIndex = i;
		}
	}

	cout << max << endl;
	cout << maxIndex + 1 << endl;

}