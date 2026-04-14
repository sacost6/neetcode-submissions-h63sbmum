class Solution {
public:
    vector<int> topKFrequent(vector<int>& nums, int k) {
        // Iterate through list and get the freq of each value
        std::unordered_map<int, int> fMap;
        for(int n : nums) {
            fMap[n]++;
        }
            
        // Iterate through the map and get top k min values
        vector<vector<int>> res(nums.size()+1);
        for(const auto& pair : fMap) {
            res[pair.second].push_back(pair.first); 
        }
        vector<int> r; 
        for(int i = res.size()-1; i > 0; i--) {
            for(int n : res[i]) {
                r.push_back(n);
                if(r.size() == k) {
                    return r; 
                }
            }
        }

        return r; 
    } 
};
