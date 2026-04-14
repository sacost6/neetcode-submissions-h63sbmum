public class Solution {
    public int MaxArea(int[] heights) {
        // Keep track of the most water found. 
        int res = 0; 

        // iterate through heights
        int l = 0; 
        int r = heights.Length - 1; 

        // two pointer
        while(l < r) {
            // calculate the area 
            int current = (r - l) * Math.Min(heights[l], heights[r]); 

            // check if the current is greater
            if(current > res) {
                res = current; 
            }
 
            if(heights[l] > heights[r]) {
                r--;
            }
            else if(heights[l] <= heights[r]) {
                l++;
            } 
        }

        return res; 
    }
}
