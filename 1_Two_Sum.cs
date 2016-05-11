using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _1_Two_Sum
    {
        public class Item
        {
            public int index;
            public int index2 = -1;
            public Item(int index)
            {
                this.index = index;
            }
        }
        private Dictionary<int, Item> _integerDictionary = new Dictionary<int, Item>();
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++){
                if (_integerDictionary.ContainsKey(nums[i])){
                    if (_integerDictionary[nums[i]].index2 == -1){
                        _integerDictionary[nums[i]].index2 = i;
                    }
                }else {
                    _integerDictionary.Add(nums[i], new Item(i));
                }
            }
            
            int[] output = new int[2];
            for (int i = 0; i < nums.Length; i++){
                if (nums[i] << 1 == target){
                    if (_integerDictionary[nums[i]].index2 == -1) {
                        continue;
                    }
                    output[0] = _integerDictionary[nums[i]].index;
                    output[1] = _integerDictionary[nums[i]].index2;
                    break;
                }
                else if (_integerDictionary.ContainsKey(target - nums[i])){
                    output[0] = i;
                    output[1] = _integerDictionary[target - nums[i]].index;
                    break;
                }
            }
            return output;
        }

        public int[] TwoSumBetter(int[] nums, int target)
        {
            Dictionary<int, int> hashtable = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++){
                int valueToFind = target - nums[i];

                if (hashtable.ContainsKey(valueToFind)){
                    int[] answer = { hashtable[valueToFind], i + 1 };
                    return answer;
                }

                if (!hashtable.ContainsKey(nums[i])){
                    hashtable.Add(nums[i], i + 1);
                }
            }

            return null;
        }
    }
}
