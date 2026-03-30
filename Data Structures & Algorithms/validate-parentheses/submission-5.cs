public class Solution {
    public bool IsValid(string s) {

        Stack<char> stack = new Stack<char>();

        foreach(char item in s)
        {
            if (item == '(' || item == '{' || item == '[' )
            {
                stack.Push(item);
                continue;
            }

            if(stack.Count == 0)
            {
                return false;
            }

            char top = stack.Pop();
            if(top == '{' && item != '}' || 
               top == '(' && item != ')' ||
                top == '[' && item != ']'               
                )
            {
                return false;
            }
        }
        
        return stack.Count == 0;
    }
}
