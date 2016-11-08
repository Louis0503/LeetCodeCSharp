using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Codility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Codility.Tests
{
    [TestClass()]
    public class RotationTests
    {
        [TestMethod()]
        public void solutionTest1()
        {
            //arrange
            var target = new Rotation();
            var numbers = new int[] { 3, 8, 9, 7 ,6 };
            var shift = 3;
            var expects = new int[] { 9, 7, 6, 3, 8 };
            //act
            var actuals = target.solution(numbers, shift);
            //assert

            CollectionAssert.AreEqual(expects, actuals);

        }
    }
}