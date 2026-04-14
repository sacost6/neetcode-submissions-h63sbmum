public class Solution {
    public List<List<int>> FourSum(int[] nums, int target) {
        // Sort array
        Array.Sort(nums); 
        // Get two outer pointers
        List<List<int>> res = new List<List<int>>(); 
        int n = nums.Length - 1; 
        for(int i = 0; i < nums.Length; i++) {
            // Skip duplicates 
            if(i > 0 && nums[i] == nums[i - 1]) continue; 
            for(int j = i+1; j < nums.Length; j++) {
                // Skip duplicates 
                if(j > i + 1 && nums[j] == nums[j - 1]) continue;

                // Get target
                long diff = (long)target - ((long)nums[i] + (long)nums[j]);

                // Look for taregt 
                int l = j + 1, r = nums.Length-1;
                while(l < r) {
                    long currSum = (long)nums[l] + (long)nums[r]; 

                    if(currSum > diff) {
                        r--;
                    }
                    else if (currSum < diff) {
                        l++;
                    }
                    else {
                        // Add the quadruplet 
                        List<int> temp = new List<int>();
                        temp.Add(nums[i]);
                        temp.Add(nums[j]); 
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
        }

        return res; 
    }
}