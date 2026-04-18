public class Solution
{
    public bool IsValid(string s)
    {

        Stack<char> stack = new Stack<char>();

        foreach (char item in s)
        {
            if (item.Equals('{') || item.Equals('(') || item.Equals('['))
            {
                stack.Push(item);
            }
            else
            {
                if (stack.Count == 0)
                {
                    return false;
                }

                char popped = stack.Pop();
                if ((popped == '{' && item != '}') || (popped == '(' && item != ')') || (popped == '[' && item != ']'))
                {
                    return false;
                }
            }
        }
        return (stack.Count == 0);
    }
}
