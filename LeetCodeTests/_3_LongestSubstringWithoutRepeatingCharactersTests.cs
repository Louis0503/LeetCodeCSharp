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
    public class _3_LongestSubstringWithoutRepeatingCharactersTests
    {
        [TestMethod()]
        public void LengthOfLongestSubstringTest()
        {
            //arrange
            var target = new _3_LongestSubstringWithoutRepeatingCharacters();
            var expects = new int[] { 1, 1, 3, 3, 1, 3, 10, 2 };
            var inputs = new string[] {"c", "aa","test", "abcabcbb", "bbbbb", "pwwkew", "testabcdfgh", "abba" };
            //act
            var actuals = new int[8];
            for(var i = 0 ; i < inputs.Length ; i++) {
                actuals[i] = target.LengthOfLongestSubstring(inputs[i]);
            }
            //assert
            CollectionAssert.AreEqual(expects, actuals);
        }

        [TestMethod()]
        public void LengthOfLongestSubstringTestSingle()
        {
            //arrange
            var target = new _3_LongestSubstringWithoutRepeatingCharacters();
            var expect = 1;
            var input = "c";
            //act

            var actual = target.LengthOfLongestSubstring(input);
            //assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod()]
        public void SetIndexTest()
        {
            //arrange
            var target = new _3_LongestSubstringWithoutRepeatingCharacters();
            var expect = 13;
            var input = "abbbbbbbbbbbba";
            //act
            target.LengthOfLongestSubstring(input);
            target.SetIndex('b', expect);
            var actual = target.GetIndex('b');
            //assert
            Assert.AreEqual(expect, actual);
        }
    }
}