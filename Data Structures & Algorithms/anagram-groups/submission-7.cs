public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        // Create dictionary of string to string
        Dictionary<string, List<string>> anagrams = new Dictionary<string, List<string>>(); 
        List<List<string>> res = new List<List<string>>(); 
        // create keys for each string
        foreach(string s in strs) {
            int[] freq = new int[26];
            foreach(char c in s) {
                freq[c - 'a']++;
            }
            string key = "";
            // create key for anagram dictionary
            foreach(int f in freq) {
                key += f.ToString() + " "; 
            }
            if(!anagrams.ContainsKey(key)) {
                anagrams[key] = new List<string>(); 
            }
            anagrams[key].Add(s);
        }

        // iterate through and add to res string
        foreach(var entry in anagrams) {
            List<string> temp = new List<string>(); 
            foreach(string s in entry.Value) {
                temp.Add(s);
            }
            res.Add(temp);
        }

        return res; 
    }
}
