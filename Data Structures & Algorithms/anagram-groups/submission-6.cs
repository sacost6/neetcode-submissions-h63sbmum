public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        // We know anagrams can be identified by the freq of letters
        
        // A simpler problem would require use of freq array 
        // to check that two words are anagrams

        // We can use the freq array to be the key and map the
        // list of strings that are anagrams

        Dictionary<string, List<string>> sMap = new Dictionary<string, List<string>>(); 
        
        foreach(string s in strs) {
            // Create freq array for the map 
            int[] freq = new int[26];
            foreach(char c in s) {
                // For each character in the given string
                // check the mapping for the array and increment
                // freq count
                freq[c - 'a']++; 
            }

            // Turn the int array into a string since not hashable 
            string key = "";
            foreach(int i in freq) {
                key += i.ToString() + " "; 
            }

            if(!sMap.ContainsKey(key)) {
                sMap[key] = new List<string>(); 
                sMap[key].Add(s);
            }
            else {
                sMap[key].Add(s);
            }
            
        }

        // Create resulting list
        List<List<string>> res = new List<List<string>>(); 

        foreach(KeyValuePair<string, List<string>> entry in sMap) {
            res.Add(entry.Value);
        }

        return res; 
    }
}
