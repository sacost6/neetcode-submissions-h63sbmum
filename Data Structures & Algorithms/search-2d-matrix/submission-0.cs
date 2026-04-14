public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        // get number of rows and columns
        int ROWS = matrix.Length; 
        int COLS = matrix[0].Length;
        // get index for the top row and bottom row
        int top = 0, bot = ROWS - 1; 
        // get row number
        int row = 0; 
        // loop while the bottom index is less than or equal to the top 
        // get the row the number is in 
        while(top <= bot) {
            row = (bot + top) / 2; 

            
            if(target > matrix[row][COLS - 1]) {
                // check the one on top
                top = row + 1; 
            }
            else if(target < matrix[row][0]) {
                // check the one under
                bot = row - 1; 
            }
            else {
                break;
            }
        }

        if(top > bot) {
            return false; 
        }

        int l = 0 , r = COLS - 1; 
        while(l <= r) {
            int m = (l + r)/2;
            if(target > matrix[row][m]) {
                l = m + 1; 
            }
            else if(target < matrix[row][m]){
                r = m - 1;
            }
            else {
                return true;
            }
        }

        return false; 
    }
}
