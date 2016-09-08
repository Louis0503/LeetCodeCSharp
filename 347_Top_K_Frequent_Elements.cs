using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public static class Top_K_Frequent_Elements
    {
        public static IList<int> TopKFrequent(int[] nums, int k)
        {
            
            var itemToCountHash = new Dictionary<int, int>();

            foreach (var element in nums){

                if (itemToCountHash.ContainsKey(element)){
                    itemToCountHash[element]++;
                }else{
                    itemToCountHash[element]=1;
                }
            }

            var orders = new List<int>();
            orders = itemToCountHash.OrderByDescending(kp => kp.Value)
                                    .Select(kp => kp.Key)
                                    .ToList();
            int[] results = new int[k];
            orders.CopyTo(0,results,0,k);
            return results;
        }
        
    }
}
