public class Solution {


    public bool hasDuplicate(int[] nums) {
    var set = new HashSet<int>();

        foreach(var num in nums) {

        if(!set.Contains(num))
        set.Add(num);

         else 
        return true;
        
        }
         return false;
    }

}