public class Solution {
    public bool IsValid(string s) {
     Stack<char> stack = new();

     foreach(char parentheses in s)
     {

if (parentheses == '(' || parentheses == '[' || parentheses == '{')
     {
    stack.Push(parentheses);
     } else {

  if(stack.Count == 0) {
    return false;
  }

char top = stack.Pop();

switch(parentheses)
{
    case ')':
    if(top != '(') return false;
    break;

    case ']':
    if(top != '[') return false;
    break;

    case '}':
    if(top != '{') return false;
    break;
}

    }
     
    }

return stack.Count == 0;

  }
}


