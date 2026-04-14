public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        // Sort the initial array 
        Array.Sort(nums);
        int n = nums.Length;
        List<List<int>> res = new List<List<int>>(); 
        // Iterate through the array to keep one grounded pointer
        for(int i = 0; i < n; i++) {
            if(i > 0 && nums[i] == nums[i - 1]) continue; // skip dups
            if(nums[i] > 0) break; // cant hit 0 with all positive numbers

            int l = i+1; 
            int r = n-1; 
            int target = -1*(nums[i]); 
            while(l < r) {
                int curr = nums[l] + nums[r];
                if(curr == target) {
                    // add to result 
                    List<int> temp = new List<int>(); 
                    temp.Add(nums[l]);
                    temp.Add(nums[r]);
                    temp.Add(nums[i]);
                    res.Add(temp);
                    l++;
                    r--;
                    while(l < r && nums[l] == nums[l-1]) l++;
                    while(l < r && nums[r] == nums[r+1]) r--; 
                    
                }
                // increase the left pointer if we need a bigger number to match target
                else if(curr < target) {
                    l++;
                }
                // decrease the right pointer if we need a smaller number to match target
                else {
                    r--;
                }
            }
        }

        return res; 
    }
}
