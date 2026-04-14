public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        // 3 arrays 
        int n = nums.Length; 
        int[] prefix = new int[nums.Length];
        int[] suffix = new int[nums.Length];
        int[] res = new int[nums.Length];

        // nothing to the left of prefix so 1
        prefix[0] = 1;
        for(int i = 1; i < n; i++) {
            prefix[i] = prefix[i - 1] * nums[i-1];
        }

        // nothing to the right of suffix so 1
        suffix[n-1] = 1;
        for(int i = n-2; i >= 0; i--) {
            suffix[i] = suffix[i+1] * nums[i+1];
        }

        // iterate to create both 
        for(int i = 0; i < n; i++) {
            res[i] = prefix[i] * suffix[i];
        }

        return res; 
 
    }
}
