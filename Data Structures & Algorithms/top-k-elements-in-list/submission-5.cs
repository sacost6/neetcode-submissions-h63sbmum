public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        // Bucket sort

        Dictionary<int, int> cMap = new Dictionary<int, int>(); 

        List<int>[] freq = new List<int>[nums.Length + 1]; 

        for(int i = 0; i < nums.Length + 1; i++) {
            freq[i] = new List<int>(); 
        }

        for(int i = 0; i < nums.Length; i++) {
            if(!cMap.ContainsKey(nums[i])) {
                cMap[nums[i]] = 0;
            }

            cMap[nums[i]]++;
        }

        foreach(var entry in cMap) {
            freq[entry.Value].Add(entry.Key); 
        }

        int[] res = new int[k];
        int index = 0; 

        for(int i = freq.Length-1; i >= 0; i--) {
            foreach(int f in freq[i]) {
                res[index++] = f;
                if(index == k) {
                    return res; 
                }
            }
        }
        return res; 
    }
}
