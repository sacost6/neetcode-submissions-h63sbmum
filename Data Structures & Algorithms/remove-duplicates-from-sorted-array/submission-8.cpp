class Solution {
public:
    int removeDuplicates(vector<int>& nums) {
        // Set a pointer 
        int l = 1;
        for(int r = 1; r < nums.size(); r++) {
            if(nums[r - 1] != nums[r]) {
                nums[l++] = nums[r];
            }
        }
        return l;
    }
};