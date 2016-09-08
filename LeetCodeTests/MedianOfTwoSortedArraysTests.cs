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
    public class MedianOfTwoSortedArraysTests
    {
        [TestMethod()]
        public void FindMedianSortedArraysTest()
        {
            //arrange
            var nums1 = new int[] { 1, 3 };
            var nums2 = new int[] { 2 };
            var expect = 2.0;
            //act 
            var actual = MedianOfTwoSortedArrays.FindMedianSortedArrays(nums1, nums2);

            //assert

            Assert.AreEqual(expect, actual);
        }

        [TestMethod()]
        public void FindMedianSortedArrays2Test()
        {
            //arrange
            var nums1 = new int[] { 1, 3 };
            var nums2 = new int[] { 2 };
            var expect = 2.0;
            //act 
            var actual = MedianOfTwoSortedArrays.FindMedianSortedArrays2(nums1, nums2);

            //assert

            Assert.AreEqual(expect, actual);
        }
    }
}