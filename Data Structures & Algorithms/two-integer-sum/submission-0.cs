public class Solution {

public int[] TwoSum(int[] nums, int target) {

 Dictionary<int, int> num_map = new Dictionary<int, int>();
 int targetNum = 0;

for(int i = 0; i < nums.Length; i++)
{

targetNum = target - nums[i]; 

if(num_map.ContainsKey(targetNum))
return new int[] { num_map[targetNum], i };

num_map[nums[i]] = i;

}

return new int[] {};
}

}
