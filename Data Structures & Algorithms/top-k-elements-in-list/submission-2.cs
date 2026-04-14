public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        // Build freq map that counts how many times  each number appears
        Dictionary<int, int> count = new Dictionary<int, int>(); 
        List<int>[] freq = new List<int>[nums.Length]; 
        for(int i = 0; i < freq.Length; i++) {
            freq[i] = new List<int>(); 
        }
        // Create a list of groups freq, where freq[i] 
        // will store all numbers that appear i times
        foreach(int n in nums) {
            if(count.ContainsKey(n)) {
                count[n]++;
            }
            else {
                count[n] = 0;
            }
        }

        foreach(var entry in count) {
            freq[entry.Value].Add(entry.Key);
        }

        int[] res = new int[k];
        int index = 0; 
        for(int i = nums.Length - 1; i >= 0; i--) 
        {
            foreach(int n in freq[i]) { 
                res[index++] = n;
                if(index == k) {
                    return res; 
                }
            }
        }
        return res; 
    }
}
