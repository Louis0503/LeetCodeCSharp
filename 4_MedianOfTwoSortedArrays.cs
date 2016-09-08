using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class MedianOfTwoSortedArrays
    {
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var length1 = nums1.Length;
            var length2 = nums2.Length;
            var total = length1 + length2;
            int index = total / 2;
            bool isFind2 = false;
            var result = 0.0;

            if(total % 2 == 0) {
                isFind2 = true;
            } else {
                index++;
            }
            
            var count = 0;
            var nums1Index = 0;
            var nums2Index = 0;
            var tmp=0;

            while(count <= index) {

                if(nums1Index >= length1) {

                    tmp = nums2[nums2Index];
                    nums2Index++;

                } else if(nums2Index >= length2) {

                    tmp = nums1[nums1Index];
                    nums1Index++;

                } else {

                    if(nums1[nums1Index] > nums2[nums2Index]) {

                        tmp = nums2[nums2Index];
                        nums2Index++;
                    } else {
                        tmp = nums1[nums1Index];
                        nums1Index++;
                    }
                }
                count++;
                if(count == index) {
                    result = tmp;
                }
                if(count == total)
                    break;
            }

            if(isFind2) {
                return (result + tmp) / 2.0;
            }else{
                return result;
            }
        }

        public static double FindMedianSortedArrays2(int[] nums1, int[] nums2)
        {

            int nums1Mid = nums1.Length - 1, nums2Mid = nums2.Length - 1;
            while(true) {
                int L1 = nums1Mid == -1 ? int.MinValue : nums1[nums1Mid >> 1];
                int R1 = nums1Mid == (2 * nums1.Length - 1) ? int.MaxValue : nums1[(nums1Mid + 1) >> 1];
                int L2 = nums2Mid == -1 ? int.MinValue : nums2[nums2Mid >> 1];
                int R2 = nums2Mid == (2 * nums2.Length - 1) ? int.MaxValue : nums2[(nums2Mid + 1) >> 1];
                if(L1 > R2) {
                    nums1Mid--;
                    nums2Mid++;
                } else if(L2 > R1) {
                    nums2Mid--;
                    nums1Mid++;
                } else {
                    return (Math.Max(L1, L2) + Math.Min(R1, R2)) / 2.0;
                }
            }
        }
    }
    
}
