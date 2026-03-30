public class Solution 
{
    public bool IsValid(string s) 
    {
        Stack<Char> st = new Stack<Char>();
        foreach(Char item in s)
        {
            if(item == '(' || item == '{' || item == '[')
            {
                st.Push(item);
            }
            else
            {
                if(st.Count == 0)
                {
                    return false;
                }
                Char top = st.Pop();
                if(top == '(' && item != ')' ||
                   top == '[' && item != ']' ||
                   top == '{' && item != '}')
                {
                    return false;
                }
            }
        }
        return st.Count == 0;
    }
}