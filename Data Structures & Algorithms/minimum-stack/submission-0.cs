public class MinStack {
Stack<int> mainStack = new();
Stack<int> minStack = new();

    public void Push(int val) {
    mainStack.Push(val);

       if(minStack.Count == 0 || minStack.Peek() > val)
      {
       minStack.Push(val);
      } else {
        minStack.Push(minStack.Peek());
      }
    
    }
    
    public void Pop() {
        mainStack.Pop();
        minStack.Pop();
    }
    
    public int Top() {
       return mainStack.Peek();
    }
    
    public int GetMin() {
        return minStack.Peek();
    }
}
