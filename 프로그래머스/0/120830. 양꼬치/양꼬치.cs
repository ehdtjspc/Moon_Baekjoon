using System;

public class Solution {
    public int solution(int n, int k) {
        int answer = 0;
        int a = n * 12000;
        int b = k * 2000;
        int c = n/10;
        int d = 0;
        if(0<c)
            d = c * 2000;
        
        answer = (a+b) - d;
            
        return answer;
    }
}