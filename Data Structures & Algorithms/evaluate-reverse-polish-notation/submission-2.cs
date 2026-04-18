public class Solution {
    public int EvalRPN(string[] tokens) {

        Stack<int> stack = new Stack<int>();

        foreach(string token in tokens)
        {
            if(int.TryParse(token, out int num))
            {
                stack.Push(num);
            }
            else
            {
                if(stack.Count > 0)
                {
                    int op1 = stack.Pop();
                    int op2 = stack.Pop();

                    switch(token) 
                    {
                        case "+" : stack.Push(op1 + op2); break;
                        case "-" : stack.Push(op2 - op1); break;
                        case "*" : stack.Push(op1 * op2); break;
                        case "/" : stack.Push(op2 / op1); break;
                    }
                }
            }
        }

        return stack.Pop();
    }
}
