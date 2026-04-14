class Solution {
public:
    bool hasDuplicate(vector<int>& nums) {
        unordered_map<int, int> nMap; 

        for(const auto& n : nums) {
            if(nMap[n]>0) {
                return true; 
            }
            nMap[n]++;
        }

        return false; 
    }
};