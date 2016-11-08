using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Codility
{
    public class Class2
    {
        
        public string solution(string S)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            var legalChars = FilterIllegalChars(S);

            return GenerateOutputString(legalChars);
        }

        private char[] FilterIllegalChars(string inputs)
        {
            var tmpChars = new List<char>();

            for(var i = 0 ; i < inputs.Length ; i++) {
                if(inputs[i] >= '0' && inputs[i] <= '9') {
                    tmpChars.Add(inputs[i]);
                }
            }

            return tmpChars.ToArray();
        }

        private string GenerateOutputString(char [] inputs)
        {
            var length = inputs.Length;

            if(length <= 3) {
                return new string(inputs);
            }

            if(length % 3 == 1) {
                return GenerateOutputSizeModByOne(inputs);
            } else if(length % 3 == 2) {
                return GenerateOutputSizeModByTwo(inputs);
            } else {
                return GenerateOutputSizeModByZero(inputs);
            }
            
        }


        private string GenerateOutputSizeModByOne(char[] inputs)
        {
            var length = inputs.Length;
            var size = length - 4;
            var sb = new StringBuilder();

            var text = GenerateTheFront3NCharsFormat(inputs, size);
            sb.Append(text);
            sb.Append(new string(inputs, length-4, 2));
            sb.Append('-');
            sb.Append(new string(inputs, length-2, 2));
            return sb.ToString();
        }


        private string GenerateTheFront3NCharsFormat(char[] inputs , int size)
        {
            var sb = new StringBuilder();

            for(var i = 0 ; i < size ; i+=3) {
                var text = new string(inputs, i, 3);
                sb.Append(text);
                sb.Append('-');
            }

            return sb.ToString();
        }

        private string GenerateOutputSizeModByTwo(char[] inputs)
        {
            var length = inputs.Length;
            var size = length - 2;
            var sb = new StringBuilder();

            var text = GenerateTheFront3NCharsFormat(inputs, size);
            sb.Append(text);
            sb.Append(new string(inputs, length - 2, 2));
            return sb.ToString();
        }

        private string GenerateOutputSizeModByZero(char[] inputs)
        {
            var length = inputs.Length;
            var size = length - 3;
            var sb = new StringBuilder();

            var text = GenerateTheFront3NCharsFormat(inputs, size);
            sb.Append(text);
            sb.Append(new string(inputs, length - 3, 3));
            return sb.ToString();
        }
    }
}
