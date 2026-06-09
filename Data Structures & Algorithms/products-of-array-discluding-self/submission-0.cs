public class Solution {

List<int> leftList = new();
List<int> rightList = new();

public int[] ProductExceptSelf(int[] nums) {
int[] output = new int[nums.Length];

for(int i = 0; i < nums.Length; i++)
{
    
if(i != 0) {
leftList.Add(leftList[i - 1] * nums[i - 1]);
} else {
leftList.Add(1);
}

}

for(int i = nums.Length - 1; i >= 0; i--) 
{

if(i != nums.Length - 1) {
rightList.Add(rightList[rightList.Count - 1] * nums[i + 1]);
} else {
rightList.Add(1);
}

}

for(int i = 0; i < nums.Length; i++) 
{
output[i] = leftList[i] * rightList[nums.Length - 1 - i];
}

return output;

}
}

