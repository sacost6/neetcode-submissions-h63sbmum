public class Solution {
    public bool IsAnagram(string s, string t) {
        // Check length
        if(s.Length != t.Length) {
            return false; 
        }

        // Create a freq array
        int[] freq = new int[26]; 

        // iterate through the string 
        for(int i = 0; i < s.Length; i++) {
            freq[s[i] - 'a']++;
            freq[t[i] - 'a']--;
        }

        // make sure everything in freq is 0
        for(int i = 0; i < 26; i++) {
            if(freq[i] != 0) {
                return false;
            }
        }

        return true;
    }
}
