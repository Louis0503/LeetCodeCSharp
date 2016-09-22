using System.Collections.Generic;

namespace LeetCode
{
    //Given an array of integers, return indices of the two numbers 
    //such that they add up to a specific target. You may assume 
    //that each input would have exactly one solution.

    public class _1_Two_Sum
    {
        public class Item
        {
            public int value;
            public int index = -1;
            public Item(int value)
            {
                this.value = value;
            }
        }

        private Dictionary<int, Item> _hash = new Dictionary<int, Item>();
        private Dictionary<int, int> _hash2 = new Dictionary<int, int>();
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++){

                if (_hash.ContainsKey(nums[i])){

                    if (_hash[nums[i]].index == -1){

                        _hash[nums[i]].index = i;
                    }
                }else {
                    _hash.Add(nums[i], new Item(i));
                }
            }
            
            int[] output = new int[2];

            for (int i = 0; i < nums.Length; i++){
                if (nums[i] << 1 == target){
                    if (_hash[nums[i]].index == -1) {
                        continue;
                    }
                    output[0] = _hash[nums[i]].value;
                    output[1] = _hash[nums[i]].index;
                    break;
                }
                else if (_hash.ContainsKey(target - nums[i])){
                    output[0] = i;
                    output[1] = _hash[target - nums[i]].value;
                    break;
                }
            }
            return output;
        }

        public int[] TwoSumBetter(int[] nums, int target)
        {
            _hash2.Clear();
            
            for (int i = 0; i < nums.Length; i++){

                int remainer = target - nums[i];

                if (_hash2.ContainsKey(remainer)){
                    int[] answer = { _hash2[remainer], i};
                    return answer;
                }
                _hash2[nums[i]] = i;
            }

            return null;
        }
    }
}
