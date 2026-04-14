class Solution {
public:

    string encode(vector<string>& strs) {
        // Create a delimter that includes size for every string 
        string res = "";
        for(const auto& s : strs) {
            // add the size and '#' to encode string
            res += to_string(s.length()) + "#" + s; 
        }

        return res; 
    }

    vector<string> decode(string s) {
        // Check size 
        int len = s.length(); 
        vector<string> res; 
        if(len == 0) {
            return res;
        }
        // Iterate through string
        int i = 0;
        while(i < len) {
            // find the delimiter
            int j = i; 
            while(s[j] != '#') {
                j++;
            }

            // any value before this should be a number
            // get the substring of the number and convert to int 
            int subLen = stoi(s.substr(i, j - i)); 

            res.push_back(s.substr(j + 1, subLen)); 

            i = j + 1 + subLen; 
        }
        return res; 
    }
};
