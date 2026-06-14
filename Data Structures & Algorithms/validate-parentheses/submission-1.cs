public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new();
        
        foreach(char parentheses in s)
        {
           if(parentheses == '(')
           {
            stack.Push(')');
           } else if (parentheses == '[')
           {
            stack.Push(']');
           } else if (parentheses == '{')
           {
            stack.Push('}');
           } else {
              if(stack.Count == 0 || stack.Pop() != parentheses) return false;
           }

        }

return stack.Count == 0;
    }
}
