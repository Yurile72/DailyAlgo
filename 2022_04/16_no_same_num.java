import java.util.*;

public class Solution {
    public int[] solution(int []arr) {
        HashSet<Integer> hashSet =
        new HashSet<>(Arrays.asList(arr));

        int[] answer = hashSet.toArray(new int[0]);

        return answer;
    }
}