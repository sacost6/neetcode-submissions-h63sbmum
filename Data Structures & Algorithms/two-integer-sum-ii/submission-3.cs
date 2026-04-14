public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        // Set up pointers
        int l = 0, r = numbers.Length-1; 

        while(l < r) {
            int curr = numbers[l] + numbers[r];

            if(curr == target) {
                return new int[] {l+1, r+1};
            }
            else if(curr < target) {
                l++;
            }
            else if(curr > target) {
                r--;
            }
        }
        return new int[0];
    }
}
