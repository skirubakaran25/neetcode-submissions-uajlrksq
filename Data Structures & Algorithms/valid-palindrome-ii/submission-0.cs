public class Solution {
   public bool ValidPalindrome(string s)
    {
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            if(s[left] != s[right])
            {
                bool result = CheckPalindrome(s, left+1, right) || CheckPalindrome(s, left, right-1);
                return result;
            }
            left++;
            right--;
        }
        return true;
    }

    public static bool CheckPalindrome(string s, int left, int right)
    {
        while(left < right)
        {
            if(s[left] != s[right])
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}