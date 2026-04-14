public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] pref = new int[nums.Length];
        int[] suff = new int[nums.Length];

        // we want all products of values to the left for pref
        // we know first is 0
        pref[0] = 1;
        for(int i = 1; i < nums.Length; i++) {
            pref[i] = pref[i-1] * nums[i-1];
        }

        // we want all prodcuts of values to the right for suff
        // last number should equal 1 bc there is nothing after it
        suff[nums.Length-1] = 1; 
        for(int i = nums.Length - 2; i >= 0; i--) {
            suff[i] = suff[i + 1] * nums[ i + 1];
        }

        // the result will be suff[i] * pref[i]
        int[] res = new int[nums.Length];
        for(int i = 0; i < nums.Length; i++) {
            res[i] = pref[i] * suff[i]; 
        }

        return res; 
    }
}
