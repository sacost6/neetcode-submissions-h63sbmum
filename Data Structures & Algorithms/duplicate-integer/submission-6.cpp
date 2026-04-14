class Solution {
public:
    bool hasDuplicate(vector<int>& nums) {
        unordered_map<int, bool> nMap;
        for(int n : nums) {
            if(nMap[n]) {
                return true; 
            }

            nMap[n] = true;
        }
        return false;
    }
};