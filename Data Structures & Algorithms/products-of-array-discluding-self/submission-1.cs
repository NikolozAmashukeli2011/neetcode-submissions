public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] output = new int [nums.Length];
        int rightProduct = 1;

       output[0] = 1;

  for(int i = 1; i < nums.Length; i++) 
   {
    output[i] = output[i - 1] * nums[i - 1];
   }

  for(int j = nums.Length - 1; j >= 0; j--)
  {
  output[j] = output[j] * rightProduct;
  rightProduct *= nums[j];

  }


return output;
}

}
