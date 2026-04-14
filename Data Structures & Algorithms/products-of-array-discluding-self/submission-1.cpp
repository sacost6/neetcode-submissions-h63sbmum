class Solution {
public:
    vector<int> productExceptSelf(vector<int>& nums) {
        // First get all the values of the product 
        int total_product = 1; 
        int zero_count = 0; 
        for(int i=0; i < nums.size(); i++) {
            if(nums[i] != 0) {
                total_product *= nums[i];
            }
            else {
                zero_count++; 
            }
            
        }

        // at least 2 zeros so every single product is 0
        if(zero_count > 1) {
            return vector<int>(nums.size(), 0);
        }



        vector<int> res(nums.size());
        // Go through, divide the total product by the ith value 
        for(int i = 0; i < nums.size(); i++) {
            if(zero_count > 0) {
                res[i] = (nums[i] == 0) ? total_product : 0;
            }
            else {
                res[i] = total_product / nums[i];
            }
        }

        return res; 
    }
};
