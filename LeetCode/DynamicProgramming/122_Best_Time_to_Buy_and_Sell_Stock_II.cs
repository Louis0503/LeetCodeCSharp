using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests.LeetCode.DynamicProgramming
{
    public  class _122_Best_Time_to_Buy_and_Sell_Stock_II
    {
        public int MaxProfit(int[] prices)
        {
            if(prices.Length <= 1) {
                return 0;
            }

            var maxProfit = 0;
            var minmum = prices[0];
            for(var i = 1 ; i < prices.Length ; i++) {
                minmum = Math.Min(prices[i], minmum);
                maxProfit = Math.Max(prices[i] - minmum, maxProfit);
            }

            return maxProfit;
        }
    }
}
