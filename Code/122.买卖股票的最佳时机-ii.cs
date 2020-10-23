/*
 * @lc app=leetcode.cn id=122 lang=csharp
 *
 * [122] 买卖股票的最佳时机 II
 */

// @lc code=start
public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int inPrice = 0;
        bool isIn = false;
        int index = 0;
        int profit = 0;
        while (index < prices.Length)
        {
            //已买入
            if (isIn)
            {
                if (index == prices.Length - 1)
                {
                    profit += (prices[index] - inPrice);
                    break;
                }
                //卖出
                if (prices[index] > prices[index + 1])
                {
                    isIn = false;
                    profit += (prices[index] - inPrice);
                }
            }
            //未买入
            else
            {
                if (index == prices.Length - 1)
                {
                    break;
                }
                //买入
                if (prices[index] < prices[index + 1])
                {
                    inPrice = prices[index];
                    isIn = true;
                }
            }
            index++;
        }
        return profit;
    }
}
// @lc code=end

