public class Solution {
    
public int CarFleet(int target, int[] position, int[] speed) {
 Stack<double> stack = new();

int carsAmount = position.Length;
double timeUntilFinish = 0;

Array.Sort(position, speed);

for(int i = carsAmount - 1; i >= 0; i--)
{
timeUntilFinish = 0;
timeUntilFinish = (double)(target - position[i]) / speed[i];
         
if(stack.Count == 0 || timeUntilFinish > stack.Peek())
{
stack.Push(timeUntilFinish);
}

}

return stack.Count;
}

}
