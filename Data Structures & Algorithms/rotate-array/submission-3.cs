public class Solution {
    public void Rotate(int[] nums, int k) {
        int n = nums.Length;
        int[] res = new int[n]; 
        k %= n;
        int l = 0; 
        int r = n - k; 

        while(l < n) {
            // if reach the end, start over
            if(r == n) {
                r = 0;
            }
            res[l++] = nums[r++]; 
        }
        Array.Copy(res, nums, n);
    }
}                       