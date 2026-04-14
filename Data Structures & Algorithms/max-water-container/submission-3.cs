public class Solution {
    public int MaxArea(int[] heights) {
        // Keep track of current MaxArea
        int maxArea = 0;  

        // Check edge cases
        if(heights.Length < 2) {
            return maxArea; 
        }

        // Keep track of left and right pointers
        int l = 0, r = heights.Length-1; 

        while(l < r) {
            // Calculate the current area
            int currHeight = Math.Min(heights[l], heights[r]) * (r - l); 

            // Check against the Max Area
            maxArea = Math.Max(maxArea, currHeight);

            if(heights[l] < heights[r]) {
                //If the limiting factor is the left hand side, check the next
                l++;
            }
            else if(heights[l] > heights[r]) {
                r--;
            }
            else {
                l++;
                r--;
            }
        }

        return maxArea; 
    }
}
