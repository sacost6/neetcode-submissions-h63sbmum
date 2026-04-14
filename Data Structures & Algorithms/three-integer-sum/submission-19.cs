public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        // Sort the initial array
        Array.Sort(nums);
        int n = nums.Length; 
        List<List<int>> res = new List<List<int>>(); 

        // Iterate using for loop to keep one pointer grounded
        for(int i = 0; i < n; i++) {
            if(i > 0 && nums[i] == nums[i - 1]) continue; 
            if(nums[i] > 0) break; 

            int l = i + 1, r = n - 1;
            int target = -1*(nums[i]);
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

                    while(l < r && nums[l] == nums[l + 1]) {
                        l++;
                    }

                    while(l < r && nums[r] == nums[r - 1]) {
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
