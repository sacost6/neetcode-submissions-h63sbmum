public class Solution {
    public bool IsAlpha(char c) {
        return (c >= 'A' && c <= 'Z') ||
               (c >= 'a' && c <= 'z') || 
               (c >= '0' && c <= '9');
    }
    public bool IsPalindrome(string s) {
        // Check edge cases
        if(s.Length <= 1) {
            return true; 
        }
        s = s.ToLower(); 
        // Set two pointers
        int l = 0, r = s.Length-1; 
        while(l < r) {
            while(l < r && !IsAlpha(s[l])) {
                l++;
            }

            while(l < r && !IsAlpha(s[r])) {
                r--;
            }

            if(s[l] != s[r]) 
            {
                return false;
            }
            r--;
            l++;
        }

        return true;
    }
}
