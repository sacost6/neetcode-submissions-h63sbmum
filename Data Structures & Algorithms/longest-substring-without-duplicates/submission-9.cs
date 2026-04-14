public class Solution {
    public int LengthOfLongestSubstring(string s) { 
        HashSet<char> set = new HashSet<char>();
        if(s.Length == 1) {
            return 1;
        }
        int l = 0, r = 0; 
        int res = 0; 
        while(r < s.Length) {
            if(!set.Contains(s[r])) {
                set.Add(s[r]);
                r++;
                res = Math.Max(res, set.Count);
            }
            else {
                set.Remove(s[l]);
                l++;
            }
        }
        return res; 
    }
}
