public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length; 
        int[] suff = new int[n];
        int[] pref = new int[n];
        int[] res = new int[n];


        // create prefix product arrays
        pref[0] = 1; 
        for(int i = 1; i < n; i++) {
            pref[i] = pref[i - 1] * nums[i - 1];
        }

        // create suffix product arrays
        suff[n-1] = 1; 
        for(int i = n-2; i >= 0; i--) {
            suff[i] = suff[i + 1] * nums[i + 1]; 
        }

        // create resulting production array
        for(int i = 0; i < n; i++) {
            res[i] = pref[i] * suff[i];
        }

        return res; 

    }
}
