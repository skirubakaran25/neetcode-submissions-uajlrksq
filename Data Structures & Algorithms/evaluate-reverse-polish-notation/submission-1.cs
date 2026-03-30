public class Solution {

    public int EvalRPN(string[] tokens) {

        Stack<int> stack = new Stack<int>();

        HashSet<String> hs = new HashSet<String>() {"+","-","*","/"};

        foreach(String token in tokens)
        {
            if(hs.Contains(token))
            {
                if(stack.Count > 0)
                {
                    int op2 = stack.Pop();
                    int op1 = stack.Pop();
                    
                    int result = token switch
                    {
                        "+" => op1 + op2,
                        "-" => op1 - op2,
                        "*" => op1 * op2,
                        "/" => op1 / op2,
                        "_" => 0
                    };
                    stack.Push(result);
                }
            }
            else
            {
                stack.Push(int.Parse(token));
            }
        }

        return stack.Pop();
    }
}
