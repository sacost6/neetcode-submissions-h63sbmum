public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int l = 0; 
        int r = numbers.Length - 1; 
        int currNum = 0; 
        while(l < r) {
            currNum = numbers[l] + numbers[r]; 
            // if the current sum is smaller, move the left pointer over 1
            if(currNum > target) {
                r--;
            } 
            else if(currNum < target) {
                l++;
            }
            else {
                return new int[] {l + 1, r + 1};
            }

            // if the left and right pointer are the same. move both 
        }

        return new int[0];
    }
}
