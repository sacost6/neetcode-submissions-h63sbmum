class Solution {
public:
    bool isPalindrome(string s) {
        // Remove none alphanumeric characters and set all characters to lowercase 
        string test = ""; 
        for(char c : s) { 
            if(isalnum(c)) {
                test += tolower(c);
            }
        }
        return test == string(test.rbegin(), test.rend());
    }
};
