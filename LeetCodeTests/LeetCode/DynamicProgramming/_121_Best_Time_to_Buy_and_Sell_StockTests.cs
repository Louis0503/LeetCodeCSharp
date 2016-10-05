using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.LeetCode.DynamicProgramming;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode.DynamicProgramming.Tests
{
    [TestClass()]
    public class _121_Best_Time_to_Buy_and_Sell_StockTests
    {
        [TestMethod()]
        public void MaxProfitTest()
        {
            //arrange
            var target = new _121_Best_Time_to_Buy_and_Sell_Stock();
            var numbers = new int[] { 7, 6, 5, 4, 3, 2, 1, };
            var expect = 0;
            //act
            var actual = target.MaxProfit(numbers);
            //assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod()]
        public void MaxProfitTest2()
        {
            //arrange
            var target = new _121_Best_Time_to_Buy_and_Sell_Stock();
            var numbers = new int[] { 7, 1, 5, 3, 6, 4 };
            var expect = 5;
            //act
            var actual = target.MaxProfit(numbers);
            //assert
            Assert.AreEqual(expect, actual);
        }
    }
}