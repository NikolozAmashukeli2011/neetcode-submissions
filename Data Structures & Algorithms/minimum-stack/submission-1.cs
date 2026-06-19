public class MinStack {
Stack<int> mainStack = new();
Stack<int> minStack = new();

    public void Push(int val) {
    mainStack.Push(val);

       if(minStack.Count == 0 || minStack.Peek() >= val)
      {
       minStack.Push(val);
      } 
    
    }
    
    public void Pop() {
int mainPoppedVal = mainStack.Pop();
     
     if(mainPoppedVal == minStack.Peek())
     {
      minStack.Pop();
     } 

    }
    
    public int Top() {
      return mainStack.Peek();
    }
    
    public int GetMin() {
      return minStack.Peek();
    }

}
