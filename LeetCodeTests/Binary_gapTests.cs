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
    public class Binary_gapTests
    {
        [TestMethod()]
        public void solutionTestMultiple()
        {
            //arrange
            var target = new Binary_gap();
            var numbers = new int[] { 0, 1, 9, 529, 20, 15, 1041};
            var expects = new int[] { 0, 0, 2, 4, 1, 0, 5 };

            //act
            var actuals = new List<int>();
            for(var i = 0 ; i < numbers.Length ; i++) {
                actuals.Add(target.solution(numbers[i]));
            }
            //asset

            CollectionAssert.AreEqual(expects, actuals);
        }

        [TestMethod()]
        public void solutionTest()
        {
            //arrange
            var target = new Binary_gap();
            var number = 20;
            var expect = 1;

            //act
            var actual = target.solution(number);
            
            //asset

            Assert.AreEqual(expect, actual);
        }

        [TestMethod()]
        public void solutionTest2()
        {
            //arrange
            var target = new Binary_gap();
            var number = 2147483647;
            var expect = 0;

            //act
            var actual = target.solution(number);

            //asset

            Assert.AreEqual(expect, actual);
        }
    }
}