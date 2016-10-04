using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _3_LongestSubstringWithoutRepeatingCharacters
    {
        private const int SIZE = 256;
        private int[] _recordLastIndex;
        public _3_LongestSubstringWithoutRepeatingCharacters()
        {
            _recordLastIndex = new int[SIZE];
        }
        public int LengthOfLongestSubstring(string s)
        {
            FlushRecords();
            var maxlength = 0;
            var start = -1;

            for (var i = 0; i < s.Length; i++) {
                var thisChar = s[i];
                var index = GetIndex(thisChar);
                
                start = Math.Max(start, index);
                maxlength = Math.Max(i - start, maxlength);
                SetIndex(thisChar , i);
            }

            return maxlength;
        }

        public int GetIndex(char c)
        {
            return _recordLastIndex[c];
        }

        public void SetIndex(char c, int index)
        {
            _recordLastIndex[c] = index;
        }

        private void FlushRecords()
        {
            for (var i = 0; i < SIZE ; i++) {
                _recordLastIndex[i] = -1;
            }
        }
    }
}
