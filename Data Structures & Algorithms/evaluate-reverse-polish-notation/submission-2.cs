public class Solution {

public int EvalRPN(string[] tokens) {

Stack<int> stack = new();
List<string> operators = new() { "+", "-", "*", "/" };
int result = 0;

foreach(string s in tokens)
{


if(operators.Contains(s)) 
{
int secondNum = stack.Pop();
int firstNum = stack.Pop();

 result = s switch
{
  "+" => firstNum + secondNum,
  "-" => firstNum - secondNum,
  "*" => firstNum * secondNum,
  "/" => firstNum / secondNum,
};

stack.Push(result);

} else {
int.TryParse(s, out int num);
stack.Push(num);
}

}

return stack.Pop();
}

}