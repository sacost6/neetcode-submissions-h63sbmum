class Solution {
public:
    bool hasDuplicate(vector<int>& nums) {
        // one pass solution
        // create a map to store numbers and they're count
        unordered_map<int, bool> nMap;

        //iterate through numbers and add to nMap 
        for(int n : nums) {
            if(nMap.contains(n)) {
                return true; 
            }
            nMap[n] = true;
        }

        return false; 
    }
};