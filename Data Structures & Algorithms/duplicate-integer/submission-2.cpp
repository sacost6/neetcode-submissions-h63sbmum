class Solution {
public:
    bool hasDuplicate(vector<int>& nums) {
        // create an unordered hash set for the seen values

        // iterate through vector, check if value already in hash map as a key
        unordered_set<int> seen;
        for(int num : nums) {
            
            if(seen.count(num)) {
                return true;
            }
            seen.insert(num);

        }

        return false ;
    }
};