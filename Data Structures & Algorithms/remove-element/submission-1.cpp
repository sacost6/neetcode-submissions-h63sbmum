class Solution {
public:
    int removeElement(vector<int>& nums, int val) {
        // set a pointer for current unique value
        int k = 0; 

        // iterate through list
        for(int i = 0; i < nums.size(); i++) {
            // if there is no match here 
            if(nums[i] != val) {
                // use pointer add non-target value to next available position
                nums[k++] = nums[i];
            }
        }

        return k; 
    }
};