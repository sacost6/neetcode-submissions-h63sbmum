public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
 
        // sort array first
        Array.Sort(nums);
        List<List<int>> res = new List<List<int>>(); 
        // Use this as a anchor to look for target
        for(int i = 0; i < nums.Length; i++) {
            if(i > 0  && nums[i - 1] == nums[i]) continue;
            if(nums[i] > 0) break;

            // this turns into a two pointer
            int l = i+1, r = nums.Length-1;
            int target = -1 * (nums[i]);
            while(l < r) {
                int curr = nums[l] + nums[r];
                if(target > curr) {
                    l++;
                }
                else if(target < curr) {
                    r--;
                }
                else {
                    // Add to result
                    List<int> temp = new List<int>(); 
                    temp.Add(nums[i]);
                    temp.Add(nums[l]);
                    temp.Add(nums[r]);
                    res.Add(temp);
                    r--;
                    l++;
                    while(l < r && nums[l - 1] == nums[l]) l++;
                    while(l < r && nums[r + 1] == nums[r]) r--;

                    
                }
            }
        }
        return res; 
    }
}
