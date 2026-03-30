public class Solution {
 public bool IsAnagram(string s1, string s2)
 {
     if (s1.Length != s2.Length)
     {
         return false;
     }

     int[] count = new int[26]; // 26 characters to accomodate the chars there

     for (int i = 0; i < s1.Length; i++)
     {
         count[s1[i] - 'a']++;
         count[s2[i] - 'a']--;
     }

     foreach (int i in count)
     {
         if (i != 0)
         {
             return false;
         }
     }

     return true;
 }
}