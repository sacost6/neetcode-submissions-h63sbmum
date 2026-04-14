public class Solution {
    public bool IsPalindrome(string s) {
        // two pointer solution 

        int l = 0;
        int r = s.Length-1; 
        s = s.ToLower(); 
        while(l < r) {
            while(!AlphaNum(s[l]) && l < r) {
                l++;
            }

            while(!AlphaNum(s[r]) && l < r) {
                r--;
            }

            if(s[l] != s[r]) {
                return false;
            }

            r--;
            l++;
        }

        return true; 
    }

    // Is AlphaNum 
    public bool AlphaNum(char c) {
        if((c >= 'a' && c <= 'z') ||
           (c >= 'A' && c <= 'Z') ||
           (c >= '0' && c <= '9')) {
            return true;
           }

        return false; 
    }
}
