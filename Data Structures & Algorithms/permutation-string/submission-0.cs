public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        // set pointers
        int l = 0; 
        
        // Keep track of the freq for the substring, permutations are just anagrams, we only care about the freq
        int[] f1 = new int[26];
        int[] f2 = new int[26];

        for(int i = 0; i < s1.Length; i++) {
            f1[s1[i] - 'a']++;
        } 

        for(int r = 0; r < s2.Length; r++) {
            f2[s2[r] - 'a']++;

            if(r >= s1.Length) { 
                f2[s2[l] - 'a']--;
                l++;
            }

            if(Enumerable.SequenceEqual(f1, f2)) return true;
        }
        return false;
    }
}
