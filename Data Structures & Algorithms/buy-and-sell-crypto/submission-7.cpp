class Solution {
public:
    int maxProfit(vector<int>& prices) {
        // Keep track of lowest price we've seen so far
        int lowestPrice = prices[0];
        int maxP = 0;
        for(int i = 1; i < prices.size(); i++) {
            if(prices[i] < lowestPrice) {
                lowestPrice=prices[i];
            }
            else {
                maxP = max(maxP, prices[i] - lowestPrice);
            } 
        }
        return maxP;
    }
};
