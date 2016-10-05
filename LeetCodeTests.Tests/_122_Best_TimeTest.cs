// <copyright file="_122_Best_TimeTest.cs">Copyright ©  2016</copyright>
using System;
using LeetCodeTests.LeetCode.DynamicProgramming;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.LeetCode.DynamicProgramming.Tests
{
    /// <summary>此類別包含 _122_Best_Time 的參數化單元測試</summary>
    [PexClass(typeof(_122_Best_Time))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class _122_Best_TimeTest
    {
        /// <summary>MaxProfit(Int32[]) 的測試虛設常式</summary>
        [PexMethod]
        public int MaxProfitTest([PexAssumeUnderTest]_122_Best_Time target, int[] prices)
        {
            int result = target.MaxProfit(prices);
            return result;
            // TODO: 將判斷提示加入 方法 _122_Best_TimeTest.MaxProfitTest(_122_Best_Time, Int32[])
        }
    }
}
