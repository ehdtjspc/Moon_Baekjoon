#include <iostream>
#include <algorithm>

using namespace std;


int main() {
    int a[101];
    int N, M, i, j, temp;

    cin >> N >> M;

    for (int b = 0; b < N; b++) {
        a[b] = b + 1;
    }


    for (int c = 0; c < M; c++) {
        cin >> i >> j;
        
        temp = a[i - 1];
        a[i - 1] = a[j - 1];
        a[j - 1] = temp;
    }

    
    for (int d = 0; d < N; d++) {
        if (d > 0) cout << " "; 
        cout << a[d];
    }
    cout << endl;

    return 0;
}