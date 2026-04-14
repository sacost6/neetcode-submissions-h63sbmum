public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {

        List<List<int>> res = new List<List<int>>(); 
        int n = nums.Length; 
        // Sort the list 
        Array.Sort(nums); 
        // Iterate through the list 
        for(int i = 0; i < n; i++) {
            // Turn that into a 2-sum problem and use two pointers
            if(i > 0 && nums[i] == nums[i - 1]) continue; 
            if(nums[i] > 0) break; 

            int target = -1 * nums[i]; 

            int l = i+1, r = n-1; 
            while(l < r) {
                int currSum = nums[l] + nums[r]; 
                if(currSum > target) {
                    r--; 
                }
                else if(currSum < target) {
                    l++;
                }
                else {
                    List<int> temp = new List<int>(); 
                    temp.Add(nums[i]); 
                    temp.Add(nums[l]);
                    temp.Add(nums[r]);
                    res.Add(temp);
                    while(l < r && nums[l] == nums[l+1]) {
                        l++;
                    }

                    while(l < r && nums[r] == nums[r-1]) {
                        r--;
                    }

                    l++;
                    r--;
                    
                }
            }
        }

        return res;  
    }
}
