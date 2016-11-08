using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Codility
{
    public class Rotation
    {
        public int[] solution(int[] A, int K)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            var length = A.Length;
            if(length < 2) {
                return A;
            }
            var shift = K % length;
            var tmpA = new int[length];

            for(var i = 0 ; i < length ; i++) {
                var newIndex = (i + shift) % length;
                tmpA[newIndex] = A[i];
            }
            return tmpA;
        }
    }
}
