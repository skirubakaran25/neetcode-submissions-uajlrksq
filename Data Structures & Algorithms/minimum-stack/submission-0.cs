public class MinStack {
    private Stack<int> minStack;
    private Stack<int> stack;

    public MinStack() {
        minStack = new Stack<int>();
        stack = new Stack<int>();
    }
    
    public void Push(int val) {
        stack.Push(val);
        if(minStack.Count == 0 || val <= minStack.Peek())
        {
            minStack.Push(val);
        }
    }
    
    public void Pop() {
        if(stack.Count == 0) return;
        var popped = stack.Pop();
        if(popped == minStack.Peek())
        {
            minStack.Pop();
        }
    }
    
    public int Top() {
        return stack.Peek();
    }
    
    public int GetMin() {
        return minStack.Peek();
    }
}
