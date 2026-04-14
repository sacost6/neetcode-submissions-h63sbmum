public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // Create a dictionary to store the numbers with their index
        Dictionary<int, int> iMap = new Dictionary<int, int>(); 

        for(int i = 0; i < nums.Length; i++) {
            // Find the complement to the target
            int diff = target - nums[i];

            if(iMap.ContainsKey(diff)) {
                return new int[] {iMap[diff], i};
            }

            iMap[nums[i]] = i;
        }

        return new int[0]; 
    }
}
