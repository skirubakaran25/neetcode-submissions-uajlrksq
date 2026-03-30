public class Solution {
    public int LengthOfLongestSubstring(string s) {

        HashSet<char> hs = new HashSet<char>();
        int left = 0;
        int right = 0;
        int max = 0;
        while(right < s.Length)
        {
            while(hs.Contains(s[right]))
            {
                hs.Remove(s[left]);
                left++;
            }

            hs.Add(s[right]);
            max = Math.Max(max, right - left + 1);
            right++;
        }

        return max;

    }
}
    