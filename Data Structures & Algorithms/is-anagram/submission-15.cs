public class Solution {
    public bool IsAnagram(string s, string t) {

        if(s.Length != t.Length) {
            return false; 
        }
         
        Dictionary<char, int> word1 = new Dictionary<char, int>(); 
        Dictionary<char, int> word2 = new Dictionary<char, int>(); 

        foreach(char c in s) {
            if(!word1.ContainsKey(c)) {
                word1[c] = 0;
            }

            word1[c]++;
        }

        foreach(char c in t) {
            if(!word2.ContainsKey(c)) {
                word2[c] = 0;
            }

            word2[c]++;
        }

        return word1.Count == word2.Count && word1.All(kvp => word2.TryGetValue(kvp.Key, out int val) && val == kvp.Value); 

    }
}
