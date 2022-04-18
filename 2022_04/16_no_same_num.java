import java.util.*;

public class Solution {
    public int[] solution(int []arr) {
        
        List<Integer> list = new ArrayList<>();
        
        for (int i = 0; i < arr.length; i++) {
            if (i == 0) {
                list.add(arr[i]);
                continue;
            }
            else if(arr[i] == arr[i-1]) {
                continue;
            }
            else {
                list.add(arr[i]);
            }
        // System.out.println(list);    
        }
        
        int[] ans = new int[list.size()];    
        for (int i = 0; i < ans.length; i++) {
            ans[i] = list.get(i);
        }
        
        return ans;
    }
}