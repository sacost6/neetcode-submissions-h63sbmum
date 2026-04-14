class Solution {
public:
    vector<int> replaceElements(vector<int>& arr) {
        int n = arr.size(); 
        int max = -1; 
        vector<int> res(n); 

        // iterate backwards
        for(int i = n-1; i >= 0; i--) {
            // push current max
            res[i] = max; 

            // check if current value for max
            max = std::max(arr[i], max); 
            
        }

        return res;
    }
};