class Solution {
public:
    bool isPalindrome(int x) {
        // seperate digits into a vector

        if(x < 0) {
            return false;

        }

        vector<int> nums; 
        while(x != 0) { 
            nums.push_back(x % 10);
            x /= 10; 
        }

        int l = 0; 
        int r = nums.size() - 1; 

        while( l < r) {
            if(nums[l] != nums[r]) {
                return false;
            }
            l++;
            r--;
        }
        return true;
    }
};