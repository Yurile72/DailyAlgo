public class Solution {
    public string solution(string s, int n) {
        string answer = "";

        // foreach (string ss in s)
        for(int i = 0; i < s.Length; i ++)  
        {
          // check white space 
          if (s[i] == ' ')
          {
            answer += ' ';
            continue;
          }

          // Upper Case
          if ((int)s[i] <= 90)
          {
            int tmp = (int)s[i];
            for(int j = 0; j < n; j++)
            {
              tmp++;
              if(90 < tmp) tmp = 65;
            }
            answer += (char)tmp;
            continue;
          }

          // lower case
          if ((int)s[i] >= 97)
          {
            int tmp = (int)s[i];
            for(int j = 0; j < n; j++)
            {
              tmp++;
              if(122 < tmp) tmp = 97;
            }
            answer += (char)tmp;
            continue;
          }
        }

        return answer;
    }
}