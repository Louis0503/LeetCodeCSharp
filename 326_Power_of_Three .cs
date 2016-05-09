using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _326_Power_of_Three
    {
        private int _maxIntegerPowerofThree = 1;

        public _326_Power_of_Three()
        {
            CalculateMaxPowerofThreeInteger();
        }
        public bool IsPowerOfThree(int n)
        {
            if (n <= 0){
                return false;
            }else {
                return _maxIntegerPowerofThree % n == 0 ? true : false;
            }
        }

        #region private methods
        private void CalculateMaxPowerofThreeInteger()
        {
            while (_maxIntegerPowerofThree * 3 > 0)
            {
                _maxIntegerPowerofThree *= 3;
            }
        }
        #endregion
    }
}
