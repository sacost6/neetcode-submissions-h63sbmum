class Solution {
public:
    vector<int> topKFrequent(vector<int>& nums, int k) {
        // Create a hash map with the key being the number and the value being the count
        unordered_map<int, int> cMap;
        vector<vector<int>> freq(nums.size() + 1);
        for(int n : nums) {
            cMap[n]++;
        }

        for(const auto& entry : cMap) {
            // iterate through all map values and insert
            // into freq array where index is # of times in array and 
            // values are numbers with that frequency 
            freq[entry.second].push_back(entry.first); 
        }

        vector<int> res; 
        for(int i = freq.size() - 1; i > 0; i--) {
            for(int n : freq[i]){
                res.push_back(n); 
                if(res.size() == k) {
                    return res; 
                }
            }
        }
    }
};
