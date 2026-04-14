class Solution {
public:
    int removeDuplicates(vector<int>& nums) {
        // set a pointer for non-duplicate value, iterator pointer, and nums size
        int l = 0, r = 0, n = nums.size();

        // iterate list while right pointer is less than the size
        while(r < n) {
            // set left point value
            // to the right pointer value (we know at this point its unique)
            nums[l]=nums[r]; 
            // while not at the end and with a duplicate value
            while(r < n && nums[l]==nums[r]) {
                // increment right pointer
                r++; 
            }
            l++;
        }
        return l; 
    }
};