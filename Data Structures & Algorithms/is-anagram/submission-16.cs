public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) {
            return false; 
        }

        // Create frequency array
        int[] freq = new int[26];

        // Iterate through both strings at the same time
        for(int i = 0; i < s.Length; i++) {
            freq[s[i] - 'a']++;
            freq[t[i] - 'a']--;

        }

        // check all values in freq are 0
        for(int i = 0; i < 26; i++) {
            if(freq[i] != 0) {
                return false; 
            }
        }
        
        return true; 
    }
}
