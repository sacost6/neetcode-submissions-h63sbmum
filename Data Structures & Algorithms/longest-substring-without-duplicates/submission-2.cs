public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> set = new HashSet<char>(); 

        int l = 0; 
        int r = 0; 
        int bestLength = 0; 
        while(r < s.Length) {
            if(!set.Contains(s[r])) { 
                set.Add(s[r]);
                bestLength = Math.Max(bestLength, set.Count);
                r++;
            }
            else {  
                set.Remove(s[l]);
                l++;
            }
        }
        return bestLength;
    }
}
