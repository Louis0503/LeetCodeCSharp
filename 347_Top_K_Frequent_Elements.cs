using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Top_K_Frequent_Elements
    {
        public IList<int> TopKFrequent(int[] nums, int k)
        {
            List<int> tmpList = new List<int>();
            Dictionary<int, int> hashDictionary = new Dictionary<int, int>();
            foreach (int element in nums){
                if (hashDictionary.ContainsKey(element)){
                    hashDictionary[element]++;
                }else{
                    hashDictionary.Add(element,1);
                }
            }

            tmpList = hashDictionary.OrderByDescending(kp => kp.Value)
                                    .Select(kp => kp.Key)
                                    .ToList();
            int[] result = new int[k];
            tmpList.CopyTo(0,result,0,k);
            return result;
        }
        
    }
}
