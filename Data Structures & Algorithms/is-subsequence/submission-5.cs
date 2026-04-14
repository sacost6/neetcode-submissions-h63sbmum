public class Solution {
    public bool IsSubsequence(string s, string t) {
        // Use two pointers

        if(s == "") {
            return true;
        }

        if(t == "") {
            return false; 
        }
        int j = 0;
        int i = 0;
        while(i < s.Length && j < t.Length) {
            if(s[i] == t[j]) {
                i++;
            }
            j++;
        }

        return i == s.Length; 
    }
}