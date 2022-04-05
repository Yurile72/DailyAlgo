// 두 수의 합
// https://programmers.co.kr/learn/courses/30/lessons/12912?language=csharp

public class Solution {
    public long solution(int a, int b) {
        long answer = 0;
        
        if(a == b) return a;
        else if(a < b)
           while (a <= b)
               answer += a++;

        else if(b < a)
           while (b <= a)
               answer += b++;
        
        return answer;
    }
}