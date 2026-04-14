class Solution {
public:
    bool isAnagram(string s, string t) {
        // Check length
        if(s.length() != t.length()) {
            return false;
        }
        // Get empty list of length 26 to represent
        // each letter and count
        vector<int> v(26, 0); 
        // Iterate through the strings
        for(int i = 0; i < s.length(); i++) {
            // Add count for the string s
            v[s[i] - 'a']++;
            v[t[i] - 'a']--;
        } 

        for(int i : v) {
            if(i<0) {
                return false;
            }
        }

        return true;
    }
};
