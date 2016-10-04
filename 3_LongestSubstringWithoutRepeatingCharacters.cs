using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _3_LongestSubstringWithoutRepeatingCharacters
    {
        private int[] _records;
        public _3_LongestSubstringWithoutRepeatingCharacters()
        {
            _records = new int[256];
        }
        public int LengthOfLongestSubstring(string s)
        {
            FlushRecords();
            var maxlength = 0;
            var start = 0;

            for (var i = 0; i < s.Length; i++) {
                var thisChar = s[i];
                var index = GetIndex(thisChar);

                if (index >=0) {
                    if (i - start > maxlength) {
                        maxlength = i - start;
                    }
                    start = index + 1;
                }
                _records[thisChar] = i;
            }

            if (s.Length - start > maxlength) {
                maxlength = s.Length - start;
            }

            return maxlength;
        }

        private int GetIndex(char c)
        {
            return _records[c];
        }

        private void FlushRecords()
        {
            for (var i = 0; i < _records.Length; i++) {
                _records[i] = -1;
            }
        }
    }
}
