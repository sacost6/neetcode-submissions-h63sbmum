public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        int[] freq1 = new int[26];
        int[] freq2 = new int[26];
        int l = 0;
        for(int i = 0; i < s1.Length; i++) {
            freq1[s1[i] - 'a']++;
        }

        for(int r = 0; r < s2.Length; r++) {
            freq2[s2[r] - 'a']++; 

            if(r >= s1.Length) {
                freq2[s2[l] - 'a']--;
                l++;
            }

            if(Enumerable.SequenceEqual(freq1, freq2)) {
                return true; 
            }
        }

        return false; 
    }
}
