public class Solution {
    public bool hasDuplicate(int[] nums) {
        // create a dictionary
        Dictionary<int, bool> dups = new Dictionary<int, bool>(); 

        // iterate through the nums array
        for(int i = 0; i < nums.Length; i++) {
            if(dups.ContainsKey(nums[i])) {
                return true; 
            }

            dups[nums[i]] = true;  
        }

        return false; 
    }
}