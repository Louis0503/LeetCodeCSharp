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
            var expects = new int []{ 3, 3, 1, 3 , 10, 2};
            var inputs = new string[] {"test", "abcabcbb", "bbbbb", "pwwkew","testabcdfgh", "abba"};
            //act
            var actuals = new int[6];
            for (var i = 0; i < inputs.Length; i++) {
                actuals[i] = target.LengthOfLongestSubstring(inputs[i]);
            }
            //assert
            CollectionAssert.AreEqual(expects, actuals);
        }
    }
}