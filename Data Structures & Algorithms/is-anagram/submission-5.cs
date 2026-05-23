public class Solution {
    public bool IsAnagram(string s, string t) {

        if(s.Length != t.Length)
        {
            return false;
        }

        s = s.ToLower();
        t = t.ToLower();
        
        int[] freqCnt = new int[26];
        
        foreach(char element in s)
        {
            freqCnt[element - 'a']++;
        }

        foreach(char element in t)
        {
            freqCnt[element - 'a']--;
        }

        foreach(int c in freqCnt)
        {
            if(c > 0)
            {
                return false;
            }
        }
        return true;
    }
}
