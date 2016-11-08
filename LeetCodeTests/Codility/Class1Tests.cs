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
    public class Class1Tests
    {
        [TestMethod()]
        public void solutionTest1()
        {
            //arrange
            var target = new Class1();
            var A = 4;
            var B = 17;
            var expect = 3;
            //act
            var actual = target.solution(A, B);
            //assert
            Assert.AreEqual(expect, actual);
        }


        [TestMethod()]
        public void solutionTest2()
        {
            //arrange
            var target = new Class1();
            var A = 23;
            var B = 24;
            var expect = 0;
            //act
            var actual = target.solution(A, B);
            //assert
            Assert.AreEqual(expect, actual);
        }

    }
}