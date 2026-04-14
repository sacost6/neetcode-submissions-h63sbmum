class Solution {
public:

    string encode(vector<string>& strs) {
        string res = "";
        for(const auto& s: strs) {
             res += to_string(s.size()) + "#" + s; 
        }
        return res;
    }

    vector<string> decode(string s) {
        vector<string> res;  
        if( s.size() == 0){
            return res; 
        }
        int i = 0; 
        int len = s.size(); 
        while(i < len) {
            // find '#' delimiter
            int j = i;
            while (s[j] != '#') j++;
            
            // any value before this should be a number for the length 
            int size = stoi(s.substr(i, j - i));

            // word should be from j+1 -> j+1+size
            res.push_back(s.substr(j + 1, size));
            i = j + 1 + size;
        }
        return res; 
    }
};