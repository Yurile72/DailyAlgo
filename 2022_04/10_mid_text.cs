public class Solution {
    public string solution(string s) {
        string answer = "";
        
        // Substring 메소드로 쉽게 해결 가능;;
        // s.Substring((s.Length % 2 == 0) ? s.Length / 2 - 1:s.Length / 2, (s.Length % 2 == 0) ? 2: 1);

        if((s.Length % 2) != 1)
        {
            answer += s[(int)(s.Length / 2)-1];
            answer += s[(int)(s.Length / 2)];
        }
        else
            answer += s[(int)(s.Length / 2)];
            
        return answer;
    }
}