public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // We use a dictionary to store each number as the key
        // and its index as the value
        Dictionary<int, int> nMap = new Dictionary<int, int>(); 

        for(int i = 0; i < nums.Length; i++) {
            // find the target
            int diff = target - nums[i];
            // check the map to see if the diff has been stored 
            if(nMap.ContainsKey(diff)) {
                return new int[] {nMap[diff], i}; 
            }
            nMap[nums[i]] = i;
        }

        return new int[] {}; 
    }
}
