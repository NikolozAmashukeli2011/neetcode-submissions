public class Solution {

public int LongestConsecutive(int[] nums) {
HashSet<int> set = new();
int longestStreak = 0;

foreach(int num in nums)
{
set.Add(num);
}

foreach(int num in set)
{

if(!set.Contains(num - 1)) 
{
int currentNum = num;
int currentLength = 1;

while(set.Contains(currentNum + 1)) 
{
currentNum++;
currentLength++;
}

if(currentLength > longestStreak)
{
 longestStreak = currentLength;
}

}

}

return longestStreak;
}


}


