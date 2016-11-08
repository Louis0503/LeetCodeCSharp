using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Codility
{
    public class Demo
    {
        private int _length;
        private long [] _sumofFrontElement;
        private long [] _sumofBackElements;
        public Demo()
        {

        }
        public int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            GenerateSumArrays(A);
            var index = GetTheFirstEquilibriumIndex();
            return index;
        }

        private void GenerateSumArrays(int[] A)
        {
            _length = A.Length;
            _sumofFrontElement = new long[_length];
            _sumofBackElements = new long[_length];

            long sum = 0;
            for(var i = 0 ; i < _length ; i++) {
                _sumofFrontElement[i] = sum;
                sum += A[i];
            }

            for(var i = 0 ; i < _length ; i++) {
                sum -= A[i];
                _sumofBackElements[i] = sum;
            }
        }

        private int GetTheFirstEquilibriumIndex()
        {
            var index = -1;

            for(var i = 0 ; i < _length ; i++) {
                if(_sumofFrontElement[i] == _sumofBackElements[i]) {
                    index = i;
                    break;
                }
            }

            return index;
        }
    }
}
