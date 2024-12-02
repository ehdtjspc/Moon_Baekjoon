#include <iostream>
using namespace std;

int main() {
    int N, j; 
    cin >> N >> j;

    int b_Number[100] = { 0 }; 

    for (int i = 0; i < j; i++) {
        int a, b, c;
        cin >> a >> b >> c;
       
        for (int d = a - 1; d < b; d++) {
            b_Number[d] = c;
        }
    }

    
    for (int i = 0; i < N; i++) {
        cout << b_Number[i] << " ";
    }

    return 0;
}
