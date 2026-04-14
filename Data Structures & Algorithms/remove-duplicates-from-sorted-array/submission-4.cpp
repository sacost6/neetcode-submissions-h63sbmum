class Solution {
public:
    int removeDuplicates(vector<int>& nums) {
        // set a left pointer to 1 since we know first value always unique
        // this will keep track of where the next non-dup value goes
        int l = 1; 
        // for loop skipping first value
        for (int r = 1; r < nums.size(); r++) { 
            // check if the current value is equal to the previous value
            if(nums[r] != nums[r-1]) {
                // increment the left pointer
                nums[l++] = nums[r];
            }
        }
        return l;
    }
};