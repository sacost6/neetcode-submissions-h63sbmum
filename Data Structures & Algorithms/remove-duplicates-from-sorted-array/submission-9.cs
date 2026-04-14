public class Solution {
    public int RemoveDuplicates(int[] nums) {
        // Check edge cases
        if(nums.Length == 0) 
        {
            return 0;
        }

        if(nums.Length == 1) {
            return 1; 
        }
        int l = 1; 
        for(int r =1; r < nums.Length; r++ ) {
            if(nums[r] != nums[l - 1]) {
                nums[l] = nums[r];
                l++;
            }
        }

        return l;
    }
}