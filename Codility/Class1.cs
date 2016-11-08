using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Codility
{
    public class Class1
    {
        
        public int solution(int A, int B)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            return GetSquareCount(B) - GetSquareCount(A);
        }

        
        private int GetSquareCount(int number)
        {
            if(number <= 0) {
                return 0;
            }

            var rootFloor = (int)Math.Sqrt(number);
            var square = rootFloor * rootFloor;
            if(number == square) {
                rootFloor -= 1;
            }
            return rootFloor;
        }
    }
}
