public class Solution {
    public string LongestCommonPrefix(string[] strs) {

        string prefix = strs[0]; // This is our base.

        for(int i = 1; i < strs.Length ; i++)
        {
            while(!strs[i].StartsWith(prefix))
            {
                prefix = prefix.Substring(0, prefix.Length - 1);

                if(prefix.Length == 0)
                {
                    prefix = "";
                }
            }
        }

        return prefix;
        
    }
}