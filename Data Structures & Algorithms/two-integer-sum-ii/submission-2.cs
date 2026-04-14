public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        // Check edge cases
        if(numbers.Length == 0) {
            return new int[0];
        }

        // Two pointers 
        int l = 0, r = numbers.Length-1; 
        while(l < r) {
            int curr = numbers[l] + numbers[r];
            if(curr < target) {
                l++;
            }
            else if(curr > target) {
                r--;
            }
            else {
                return new int[] {l + 1 , r + 1};
            }
        }

        return new int[0];
    }
}
