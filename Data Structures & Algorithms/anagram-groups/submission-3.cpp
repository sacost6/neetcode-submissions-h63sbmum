class Solution {
public:
    vector<vector<string>> groupAnagrams(vector<string>& strs) {
        // Use an unordered map with sorted anagram value as key
        std::unordered_map<string, vector<string>> matches; 

        // Go through every string and build a '0,0,...,1' string for char freq
        for(const auto& s : strs) {
            vector<int> freq(26, 0); 
            for(char c : s) {
                freq[c - 'a']++;
            }
            string key = "";
            for(int i : freq) {
                if(key == "") {
                    key = to_string(i);
                }
                else {
                    key += "," + to_string(i);
                } 
            }
            matches[key].push_back(s);
        }

        // create result vector
        vector<vector<string>> res;
        for(const auto& pair : matches) {
            res.push_back(pair.second); 
        }

        return res; 
    }
};
