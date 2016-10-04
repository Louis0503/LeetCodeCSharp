using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Binary_gap
    {
        private int[]  _records;

        public Binary_gap()
        {
            _records = new int[32];
        }
        public int solution(int N)
        {
            GenerateRecords(N);
            return GetMaxGap();
        }

        private void GenerateRecords(int number)
        {
            var tmp = number;
            for(var i = 0 ; i < 31 ; i++) {
                _records[i] = tmp & 1;
                tmp >>= 1;
            }
        }

        private int GetMaxGap()
        {
            var maxGap = 0;
            var tmpGap = 0;
            var startRecord = false;
            for(var i = 30 ; i >=0 ; i--) {
                if(_records[i] == 0) {
                    tmpGap++;
                } else {
                    if(startRecord) {
                        maxGap = Math.Max(maxGap, tmpGap);
                    } else {
                        startRecord = true;
                    }
                    tmpGap = 0;
                }
            }
            return maxGap;
        }
        
    }
}
