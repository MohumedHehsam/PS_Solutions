public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int buy = -prices[0], sell = 0, rest = 0;

        for (int i = 1; i < prices.Length; i++)
        {
            var prevBuy = buy;
            var prevSell = sell;
            var prevRest = rest;

            buy = Math.Max(prevRest - prices[i], buy);
            sell = prevBuy + prices[i];
            rest = Math.Max(prevRest, prevSell);
        }

        return Math.Max(sell,rest);
    }
}