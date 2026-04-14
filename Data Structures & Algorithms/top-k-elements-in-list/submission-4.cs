public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        // Going to use a bucket sort for this

        // create a dictionary object to store frequencies of values
        Dictionary<int, int> freq = new Dictionary<int, int>(); 

        // create an arry of list of integers of size nums.Length 
        List<int>[] array = new List<int>[nums.Length + 1];

        // initiate all lists in array
        for(int i = 0; i <= nums.Length; i++) {
            array[i] = new List<int>(); 
        }

        // get frequencies 
        foreach(int i in nums) {
            if(!freq.ContainsKey(i)) freq[i] = 0;
            freq[i]++;
        } 

        // place frequecnies in array
        foreach(var entry in freq) {
            array[entry.Value].Add(entry.Key);
        }

        // check freq array in reverse for k largest elemnts
        int[] res = new int[k];
        int index = 0; 

        for(int i = array.Length - 1; i >= 0 && index < k; i--) {
            foreach(int num in array[i]) {
                res[index++] = num; 
                if(index == k) {
                    return res; 
                }
            }
             
        }

        return new int[0]; 
    }
}
