public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        // Use Hash Set to keep track of nums 
        HashSet<int> set = new HashSet<int>(); 

        for(int i = 0; i < nums.Length; i++) {
            // Check if the current number is in the set, if it is then a dup exists
            if(set.Contains(nums[i])) {
                return true; 
            }

            // Not in the set, remove the (i - k)th value
            
            if(i >= k) {
                set.Remove(nums[i - k]);
            }
            // and add the current int to the set
            set.Add(nums[i]); 
        }

        return false; 
    }
}