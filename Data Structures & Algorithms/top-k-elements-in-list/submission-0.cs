public class Solution {

public int[] TopKFrequent(int[] nums, int k) {

var map = new Dictionary<int, int>();

foreach(var num in nums)
{

 map[num] = map.GetValueOrDefault(num, 0) + 1;

}

return map.OrderByDescending(kvp => kvp.Value)
.Take(k)
.Select(kvp => kvp.Key)
.ToArray();

}

}
