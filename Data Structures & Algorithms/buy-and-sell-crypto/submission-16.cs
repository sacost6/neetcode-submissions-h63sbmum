public class Solution {
    public int MaxProfit(int[] prices) {
        // keep track of the max profit 
        int res = 0; 

        // Check edge cases
        if(prices.Length < 1) return 0;  

        // set the left and right pointers
        int l = 0;
        int r = l + 1; 

        while(r < prices.Length) {
            // check the current price 
            int currProfit = prices[r] - prices[l];

            res = Math.Max(res, currProfit);

            // check which pointer to move
            if(prices[l] >= prices[r]) {
                l = r; 
                r++;
            } 
            else {
                r++;
            } 
        }
        return res; 
    }
}
