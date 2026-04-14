class Solution {
public:
    vector<int> productExceptSelf(vector<int>& nums) {
        // use brute force
        vector<int> res; 
        for(int i = 0;i < nums.size(); i++) {
            // skip this 
            int val = 1;
            for(int j = 0; j < nums.size(); j++) {
                if(i == j) {
                    continue;
                }
                cout << nums[j] << " "; 
                val = val * nums[j]; 
            }
            cout << "\n";
            res.push_back(val);
        }
        return res;
    }
};
