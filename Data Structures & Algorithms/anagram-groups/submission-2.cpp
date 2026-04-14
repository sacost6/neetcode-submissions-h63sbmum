class Solution {
public:
    vector<vector<string>> groupAnagrams(vector<string>& strs) {
        // Use unordered map and string of letter frequencies 
        unordered_map<string, vector<string>> sMap; 
        
        for(const auto& s : strs) {
            // Get string like '0, 0, 1, 0, ..., 0' for frequency of each string
            int freq[26] = {0};
            string key = "";
            for(char c : s) {
                freq[c-'a']++;
            }

            // Create string that will be the key 
            for(int c : freq) {
                if(key == "") {
                    key = to_string(c);
                }
                else {
                    key += "," + to_string(c);
                }
            }

            sMap[key].push_back(s);  
        }
        // Iterate through the map and push the list of strings to the list of list of strings. 
        vector<vector<string>> res;
        for(const auto& pair : sMap) {
            res.push_back(pair.second); 
        }
        return res;
    }
};
