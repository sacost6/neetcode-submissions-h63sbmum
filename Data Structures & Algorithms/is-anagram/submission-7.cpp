class Solution {
public:
    bool isAnagram(string s, string t) {
        // Using array 

        // We know it has to be equal length 
        if(s.length() != t.length()) {
            return false; 
        }

        // We know there are 26 letters
        vector<int> count(26, 0);

        for(int i = 0; i < s.length(); i++) {
            count[s[i] - 'a']++;
            count[t[i] - 'a']--;
        }

        for(int n : count) {
            if(n != 0) {
                return false; 
            }
        }

        return true;
    }
};
