using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _231_Power_of_Two
    {
        private int _maxIntegerPowerofTwo = 1<<30;
        public bool IsPowerOfTwo(int n)
        {
            if (n <= 0){
                return false;
            }else {
                return _maxIntegerPowerofTwo % n == 0 ? true : false;
            }
        }
    }
}
