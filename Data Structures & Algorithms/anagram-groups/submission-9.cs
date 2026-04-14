public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        // Create the resulting list
        List<List<string>> res = new List<List<string>>(); 

        // Create a dictionary of string -> List<string> 
        Dictionary<string, List<string>> map = new Dictionary<string, List<string>>(); 

        foreach(string s in strs) {
            string key = "";
            int[] freq = new int[26];

            // Populate the frequency array for this string
            foreach(char c in s) {
                freq[c - 'a']++;
            }

            // Turn the freq array to a string for key use
            foreach(int f in freq) 
            {
                key += f.ToString() + " "; 
            }

            // Add the original string to the 
            if(!map.ContainsKey(key)) {
                map[key] = new List<string>();
            }
            
            map[key].Add(s); 
        }

        foreach(var entry in map) {
            List<string> t = new List<string>(); 
            foreach(string s in entry.Value) {
                t.Add(s);
            }
            res.Add(t);
        }

        return res; 
    }
}
