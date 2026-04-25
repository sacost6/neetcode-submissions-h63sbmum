public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        // Need to find a way to group all these together given a similar feature
        Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>(); 

        // For anagrams, we care about the frequency of characters
        // Use a frequency array turned to a string  as the key 
        // Add the matching strings to the list
        foreach(string s in strs) {
            // Create a freq array
            int[] freq = new int[26];

            // iterate through the string and increment character count by index
            foreach(char c in s) {
                freq[c - 'a']++;
            }

            // turn the freq array into a string to use as the key
            string key = "";
            for(int i = 0; i < 26; i++) {
                string temp = freq[i].ToString(); 
                key += temp + ","; 
            }

            // Add to key's list
            if(!dict.ContainsKey(key)) {
                dict[key] = new List<string>(); 
            }

            dict[key].Add(s);
        }

        // Create the resulting list 
        List<List<string>> result = new List<List<string>>(); 

        // Iterate through each entry
        foreach(var entry in dict) {
            // Create emtpy list of string
            List<string> groupedStrings = new List<string>(); 

            // Iterate through each string in the entry
            foreach(string s in entry.Value) {
                groupedStrings.Add(s);
            }
            result.Add(groupedStrings);
        }
        return result; 
    }
}
