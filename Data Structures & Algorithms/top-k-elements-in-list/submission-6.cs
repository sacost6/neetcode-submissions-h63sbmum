public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        // Using bucket sort
        int[] res = new int[k];

        // Check edge cases
        if(k <= 0) {
            return res;
        }

        // Initialize an array of freq 
        List<int>[] freq = new List<int>[nums.Length + 1];
        for(int i = 0; i < freq.Length ; i++) {
            freq[i] = new List<int>(); 
        }
        // Initialize an count dictionary
        Dictionary<int, int> cMap = new Dictionary<int, int>(); 

        for(int i = 0; i < nums.Length; i++) {
            if(!cMap.ContainsKey(nums[i])) cMap[nums[i]] = 0;

            cMap[nums[i]]++; 
        }


        // Set freq array 
        foreach(var entry in cMap) {
            
            freq[entry.Value].Add(entry.Key);
        }

        int index = 0; 
        for(int i = freq.Length-1; i >= 0; i--) {
            foreach(int num in freq[i]) {
                res[index++] = num;
                if(index == k) { 
                    return res;
                }
                
            } 
        }

        return res; 


    }
}
