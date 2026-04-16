public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // Create dictionary for keeping track of complement value
        Dictionary<int, int> complements = new Dictionary<int, int>();  
        // iterate through loop and look for complements
        for(int i = 0; i < nums.Length; i++) {
            // Get the complement number
            int complement = target - nums[i];
            // check if the necessary complement is already in 
            if(complements.ContainsKey(complement)) {
                return new int[] {complements[complement], i};
            }
            complements[nums[i]] = i;
        }

        return new int[] {}; 
    }
}
