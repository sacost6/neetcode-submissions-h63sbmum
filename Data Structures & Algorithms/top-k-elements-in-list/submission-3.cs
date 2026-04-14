public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        // create a count map for numbers and their freq
        Dictionary<int, int> count = new Dictionary<int, int>(); 
        List<int>[] freq = new List<int>[nums.Length + 1];
        for(int i = 0; i < freq.Length; i++) {
            freq[i] = new List<int>(); 
        }
        // populate the count map
        foreach(int num in nums) {
            if(!count.ContainsKey(num)) {
                count[num] = 0;
            }
            else {
                count[num]++;
            }
        }

        // Create a list of [freq, num] for all nums in array
        foreach(var entry in count) {
            // set the freq at the i'th value  
            freq[entry.Value].Add(entry.Key);
        }

        // create resulting array of size k 
        int[] res = new int[k]; 
        int index = 0; 

        for(int i = nums.Length - 1; i >= 0 && index < k; i--) {
            // iterate through the numbers in the freq array at this position 
            foreach(int n in freq[i]) {
                // add to resulting array
                res[index] = n; 
                index++;
                // check if index is of size k; 
                if(k == index) {
                    return res; 
                }
            }
        }

        return res; 
    }
}
