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
    public class Class3Tests
    {
        [TestMethod()]
        public void solutionTestOverflow()
        {
            //arrange
            var target = new Class3();
            var inputs = "444445*****";
            var expect = -1;
            //act
            var actual = target.solution(inputs);
            //assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod()]
        public void solutionTestTooManyOperator()
        {
            //arrange
            var target = new Class3();
            var inputs = "44*****";
            var expect = -1;
            //act
            var actual = target.solution(inputs);
            //assert
            Assert.AreEqual(expect, actual);
        }


        [TestMethod()]
        public void solutionTestTooManyOperator2()
        {
            //arrange
            var target = new Class3();
            var inputs = "11++";
            var expect = -1;
            //act
            var actual = target.solution(inputs);
            //assert
            Assert.AreEqual(expect, actual);
        }


        [TestMethod()]
        public void solutionTestTooManyOperator3()
        {
            //arrange
            var target = new Class3();
            var inputs = "13+62*7+*";
            var expect = 76;
            //act
            var actual = target.solution(inputs);
            //assert
            Assert.AreEqual(expect, actual);
        }
    }
}