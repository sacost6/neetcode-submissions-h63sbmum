public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> set = new HashSet<char>(); 
        int res = 0;
        int l = 0, r = 0; 
        while(r < s.Length) {
            // check if char in set
            if(!set.Contains(s[r])) {
                set.Add(s[r]);
                res = Math.Max(res, set.Count);
                r++;
            }
            else {
                set.Remove(s[l]);
                l++;
            }
        }

        return res; 
    }
}
