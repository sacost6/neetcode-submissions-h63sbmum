class Solution {
public:
    int maxArea(vector<int>& heights) {
        // set up two pointer 
        int l= 0, r=heights.size() -1;
        int res = 0;
        while(l < r) {
            // check the area
            int area = (r - l) * min(heights[l], heights[r]);
            res = max(area, res);
            
            if(heights[l] < heights[r]) {
                l++;
            }
            else {
                r--;
            }  
        }

        return res; 

    }
};
