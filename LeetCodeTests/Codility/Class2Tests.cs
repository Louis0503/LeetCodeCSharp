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
    public class Class2Tests
    {
        [TestMethod()]
        public void solutionTest()
        {
            //arrange
            var target = new Class2();
            var inputs = "00-44 48 5555 8361";
            var expect = "004-448-555-583-61";
            //act
            var actual = target.solution(inputs);
            //assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod()]
        public void solutionTest2()
        {
            //arrange
            var target = new Class2();
            var inputs = "0 - 22                   1 9 8 5----------324";
            var expect = "022-198-53-24";
            //act
            var actual = target.solution(inputs);
            //assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod()]
        public void solutionTest3()
        {
            //arrange
            var target = new Class2();
            var inputs = "02-----------------------------------";
            var expect = "02";
            //act
            var actual = target.solution(inputs);
            //assert
            Assert.AreEqual(expect, actual);
        }


        [TestMethod()]
        public void solutionTest4()
        {
            //arrange
            var target = new Class2();
            var inputs = "02---------------------------------11";
            var expect = "02-11";
            //act
            var actual = target.solution(inputs);
            //assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod()]
        public void solutionTest5()
        {
            //arrange
            var target = new Class2();
            var inputs = "012345";
            var expect = "012-345";
            //act
            var actual = target.solution(inputs);
            //assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod()]
        public void solutionTest6()
        {
            //arrange
            var target = new Class2();
            var inputs = "012-012-012-012-012-012-012-012-012-012-012-";
            var expect = "012-012-012-012-012-012-012-012-012-012-012";
            //act
            var actual = target.solution(inputs);
            //assert
            Assert.AreEqual(expect, actual);
        }
    }
}