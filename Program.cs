using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            _1_Two_Sum test = new _1_Two_Sum();
            int[] testdata = {3, 2, 4};
            int target = 6;
            test.TwoSum(testdata, target);
            Console.ReadKey();
        }
    }
}
