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
    public class DemoTests
    {

        [TestMethod()]
        public void solutionTestEmpty()
        {
            //arrange
            var target = new Demo();
            var numbers = new int[0];
            var expect = -1;
            //act
            var actual = target.solution(numbers);
            //assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod()]
        public void solutionTest1()
        {
            //arrange
            var target = new Demo();
            var numbers = new int[] { -1, 3, -4, 5, 1, -6, 2, 1 };
            var expect = 1;
            //act
            var actual = target.solution(numbers);
            //assert
            Assert.AreEqual(expect, actual);


        }

        [TestMethod()]
        public void solutionTest2()
        {
            //arrange
            var target = new Demo();
            var numbers = new int[] { 1,2,3,4,5,6,7};
            var expect = -1;
            //act
            var actual = target.solution(numbers);
            //assert
            Assert.AreEqual(expect, actual);
        }
    }
}