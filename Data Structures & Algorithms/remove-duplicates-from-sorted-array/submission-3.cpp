class Solution {
public:
    int removeDuplicates(vector<int>& nums) {
        // set up two pointers and a variable to store vector size
        int l = 0, r = 0, n = nums.size(); 

        // iterate while the right pointer is less than the size of the vector
        while(r < n) { 
            // set left pointer value equal to right pointer value
            nums[l] = nums[r]; 

            // increment the right as long as the
            // current values are equal 
            while(r < n && nums[r] == nums[l]) {
                r++;
            }

            // once they are no longer equal, increment l by 1
            // this is the tracking pointer
            l++; 
        }
        
        return l;
    }
};