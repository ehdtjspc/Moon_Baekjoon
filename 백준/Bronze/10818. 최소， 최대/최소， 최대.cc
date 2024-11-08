#include <iostream>
#include <algorithm>

using namespace std;

int main(){


    int a;
    cin >> a;
    int b[1000000];

    for(int i=0; i<a; i++ )
    {
        
        cin >> b[i];

    }
    
    sort(b,b+a);

    cout << b[0] << " " << b[a-1]<< endl;
    return 0;
}