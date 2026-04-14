using namespace std; 
class Solution {
public:
    bool isPalindrome(string s) {
        // Create empty string
        string newStr = "";
        for (char c : s) {
            if(isalnum(c)) {
                newStr += tolower(c);
            }
        }

        return newStr == string(newStr.rbegin(), newStr.rend());
    }
};
