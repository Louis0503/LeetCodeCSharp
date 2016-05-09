using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _258_Add_Digits
    {
        public int AddDigits(int num)
        {
            if (num == 0)
            {
                return 0;
            }
            else {
                return num % 9 == 0 ? 9 : num % 9;
            }
        }
    }
}
