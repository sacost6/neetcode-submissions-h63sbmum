class Solution {
public:
    int maxProfit(vector<int>& prices) {
        // Set up left and right index
        int l=0, r=1; 

        int maxP = 0; 

        while(r < prices.size()) {
            if(prices[l] < prices[r]) {
                // calculate max profit
                // because future price is higher 
                maxP = max(maxP, prices[r] - prices[l]);
            }
            else {
                // better day to buy
                // because future price is lower
                // move the lower bound pointer to the right
                l = r;
            }
            // move upper bound pointer to the right
            r++;
        }

        return maxP;
    }
};
