public class Solution {
    public bool IsAnagram(string s, string t) {
        // For anagrams, we care about the frequency of the characters


        // First, if lengths are mismatching we know this is false
        if(s.Length != t.Length) {
            return false; 
        }

        // Use an array of size 26 to count frequency of each character
        int[] freq = new int[26];

        for(int i = 0; i < s.Length; i++) {
            // increment the character's frequency
            // we know alphabetical letters can be subtracted by 'a' 
            // to get the position in the array
            freq[s[i] - 'a']++;
            freq[t[i] - 'a']--;
        }

        // if the freq is the same for both
        // make sure the array is all zeros 

        for(int i = 0; i < 26; i++) {
            if(freq[i] != 0) {
                return false; 
            } 
        }

        return true; 

    }
}
