using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests
{
    [TestClass()]
    public class _1_Two_SumTests
    {
        [TestMethod()]
        public void TwoSumTest()
        {
            //arrange
            var target = new _1_Two_Sum();
            var numbers = new int[] { 2, 7, 11, 15 };
            var numbers2 = new int[] { 2, 7, 11, 15 };
            var sum = 9;
            var expect = new int[] { 0, 1 };
            //act
            var actual = target.TwoSum(numbers, sum);
            var actual2 = target.TwoSumBetter(numbers2, sum);
            //assert
            CollectionAssert.AreEqual(expect, actual);
            CollectionAssert.AreEqual(expect, actual2);
        }
    }
}
