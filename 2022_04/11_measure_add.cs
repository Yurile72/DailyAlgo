using System;

// https://programmers.co.kr/learn/courses/30/lessons/77884
// 약수의 개수와 덧셈
public class Solution {
    public int solution(int left, int right) {
      int add_num = left;
      int answer = 0;

      while(add_num <= right)
      {
        if(measure_even(add_num))
          answer += add_num;
        else
          answer -= add_num;
        add_num++;
      }

      return answer;
    }

    // 약수 계산
    // 짝수면 트루 반환
    public bool measure_even(int a)
    {
      int cnt = 0;

      for (int i = 1; i <= a; i++)
          if (a % i == 0)
            cnt++;

      if (cnt % 2 == 0)
        return true;
      else
        return false;
    }
}

// 근데 이거 다시 효율좋게 풀어야댐