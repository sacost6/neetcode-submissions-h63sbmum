public class Solution {
    public bool IsAnagram(string s, string t) {
        // same freq of characters in each string

        if(s.Length != t.Length) {
            return false; 
        }

        int[] freq = new int[26];

        for(int i = 0; i < s.Length; i++) {
            freq[s[i] - 'a']++;
            freq[t[i] - 'a']--;
        }

        foreach(int f in freq) {
            if(f != 0) {
                return false; 
            }
        }
        return true; 
    }
}
