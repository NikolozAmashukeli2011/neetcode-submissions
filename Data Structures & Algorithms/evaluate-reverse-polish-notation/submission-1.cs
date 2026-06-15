public class Solution {

public int EvalRPN(string[] tokens) {
    
Stack<string> stack = new();
List<string> operators = new() { "+", "-", "*", "/" };
int result = 0;

foreach(string s in tokens)
{
    if(operators.Contains(s)) 
    {
    int.TryParse(stack.Pop(), out int secondNum);
    int.TryParse(stack.Pop(), out int firstNum);

 result = s switch
{
    "+" => firstNum + secondNum,
    "-" => firstNum - secondNum,
    "*" => firstNum * secondNum,
    "/" => firstNum / secondNum,
};

stack.Push(result.ToString());

} else {
stack.Push(s);
}

}

int.TryParse(stack.Pop(), out int answer);

return answer;
}

}
