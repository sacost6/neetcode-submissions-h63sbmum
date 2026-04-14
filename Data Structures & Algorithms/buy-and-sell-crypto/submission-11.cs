public class Solution {
    public int MaxProfit(int[] prices) {
        // Set up left and right pointers
        int l = 0, r = l + 1; 
        int maxProfit = 0; 
        // iterate until pointers swap roles
        while(r < prices.Length) {
            // Check for max profit
            int currProfit = prices[r] - prices[l]; 
            
            if(maxProfit < currProfit) {
                maxProfit = currProfit; 
            }
             
            // Price for tomorrow is lower, buy tomorrow
            if(prices[l] >= prices[r]) {
                l=r; 
                r++;
            }
            // Price for tomorrow is already higher, check the day after that 
            else {
                r++; 
            }

        }

        return maxProfit; 
    }
}
