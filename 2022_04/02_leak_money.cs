using System;

class Solution
{
    public long solution(int price, int money, int count)
    {
        // int로 하면 저장 가능한 범위 벗어남;;      
        long condict = 0;

        for(int i = 1; i <= count; i++)
          condict += price * i;
        
        return (money <= condict ? (condict - money) : 0);

    }
}