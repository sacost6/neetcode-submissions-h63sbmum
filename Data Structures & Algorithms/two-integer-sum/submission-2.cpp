class Solution {
public:
    vector<int> twoSum(vector<int>& nums, int target) {
        // Use a hash map to track the remaining value for the target
        std::unordered_map<int, int> tMap; 
        vector<int> res; 
        // Iterate to load the map first
        for(int i = 0; i < nums.size(); i++) {
            int tVal = target - nums[i]; 

            tMap[tVal] = i;
        }


        // Iterate again to search the map 
        for(int i = 0; i < nums.size(); i++) {
            if(tMap.contains(nums[i]) && i != tMap[nums[i]]) {
                res.push_back(i);
                res.push_back(tMap[nums[i]]);
                break;
            }
        }

        return res; 
    }
};
