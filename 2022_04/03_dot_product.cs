using System;

public class Solution {
    public int solution(int[] a, int[] b) {
        int answer = 0;

        // Linq에서 Zip으로도 풀어볼 수 있음.
        for(int i = 0; i < a.Length; i++)
          answer += (a[i] * b[i]);
    
        return answer;
    }
}