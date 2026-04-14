public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        // sort 
        Array.Sort(nums);
        int n = nums.Length;
        
        // create list
        List<List<int>> res = new List<List<int>>(); 

        // iterate through i 
        for(int i = 0; i < n; i++) {
            if(nums[i] > 0) break;
            if(i > 0 && nums[i] == nums[i - 1]) continue;

            int target = -1 * nums[i]; 
            int l = i+1;
            int r = n-1;

            while(l < r) {
                int currSum = nums[l] + nums[r];

                if(currSum > target) {
                    // move right target to the left
                    r--;
                }
                else if(currSum < target) {
                    // move left target to the right
                    l++;
                }
                else {
                    // found a hit, add to list
                    List<int> temp = new List<int>(); 
                    temp.Add(nums[i]);
                    temp.Add(nums[l]);
                    temp.Add(nums[r]);
                    res.Add(temp);
                    l++; 
                    r--; 
                    while(l < r && nums[l] == nums[l-1]) {
                        l++;
                    }
                    
                }
            } 
        }
        return res;
    }
}
