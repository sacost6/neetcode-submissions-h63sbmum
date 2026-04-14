public class Solution {
    public int MaxProfit(int[] prices) {
        // sliding window 
        int l = 0; 
        int r = l + 1;

        int maxProfit = 0; 
        while(r < prices.Length) {
            int currProfit = prices[r] - prices[l]; 

            if(currProfit > maxProfit) {
                maxProfit = currProfit; 
            }

            if(prices[l] >  prices[r]) {
                l = r; 
                r++;
            }
            else {
                r++; 
            }
        }

        return maxProfit; 
    }
}
