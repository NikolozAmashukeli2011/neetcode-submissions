public class Solution {

public int[] TwoSum(int[] nums, int target) {

 Dictionary<int, int> numMap = new Dictionary<int, int>();

  for(int i = 0; i < nums.Length; i++)
  {

    int neededNum = target - nums[i];

   if(numMap.ContainsKey(neededNum)) {
    return new int[] {numMap[neededNum], i};
   }

    numMap.Add(nums[i], i);

  }

  return new int[] {};

}

}
