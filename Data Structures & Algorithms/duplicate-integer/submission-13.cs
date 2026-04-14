public class Solution {
    public bool hasDuplicate(int[] nums) {
        // Create a dictionary
        HashSet<int> set = new HashSet<int>(); 


        // iterate 
        for(int i = 0; i < nums.Length; i++) {
            if(set.Contains(nums[i])) {
                return true;
            }
            // set the value as the index n key as the number
            set.Add(nums[i]);
        }

        return false; 
    }
}