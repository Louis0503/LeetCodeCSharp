using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeTests.LeetCode.DynamicProgramming;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests.LeetCode.DynamicProgramming.Tests
{
    [TestClass()]
    public class _122_Best_Time_to_Buy_and_Sell_Stock_IITests
    {
        [TestMethod()]
        public void MaxProfitTest1()
        {
            //arrange
            var target = new _122_Best_Time_to_Buy_and_Sell_Stock_II();
            var numbers = new int[] { 7, 6, 5, 4, 3, 2, 1 };
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
            var target = new _122_Best_Time_to_Buy_and_Sell_Stock_II();
            var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7};
            var expect = 6;
            //act
            var actual = target.MaxProfit(numbers);
            //assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod()]
        public void MaxProfitTest3()
        {
            //arrange
            var target = new _122_Best_Time_to_Buy_and_Sell_Stock_II();
            var numbers = new int[] { 1, 7, 2, 6, 3, 4, 5};
            var expect = 12;
            //act
            var actual = target.MaxProfit(numbers);
            //assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod()]
        public void MaxProfitTest4()
        {
            //arrange
            var target = new _122_Best_Time_to_Buy_and_Sell_Stock_II();
            var numbers = new int[] { 1, 6, 6, 10};
            var expect = 9;
            //act
            var actual = target.MaxProfit(numbers);
            //assert
            Assert.AreEqual(expect, actual);
        }
    }
}