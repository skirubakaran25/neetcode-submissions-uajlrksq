public class Solution {
   public bool IsSubsequence(string s, string t)
    {
        int sLen = s.Length, tLen = t.Length;


        int s1 = 0, t1 = 0;

        while(s1 < sLen && t1 < tLen)
        {
            if(s[s1] == t[t1])
            {
                s1++;
            }
            t1++;
        }

        if(s1 == sLen)
        {
            return true;
        }

        return false;
       
    }
}