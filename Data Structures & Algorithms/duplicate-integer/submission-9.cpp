class Solution {
public:
    bool hasDuplicate(vector<int>& nums) {
        // Create an unordered map to store each number
        std::unordered_map<int, bool> nMap; 

        // Check each number
        for(int n : nums) {
            // check if the hash map contains the value
            if(nMap.contains(n)) {
                // already in the map, so false
                return true; 
            }
            // set the value to true
            nMap[n] = true; 
        }
        // no dups found 
        return false; 
    }
};