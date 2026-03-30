public class Solution {
 public List<List<string>> GroupAnagrams(string[] strs)
 {

     Dictionary<string, List<string>> map = new();

     foreach (string str in strs) 
     {
         char[] sorted = str.ToCharArray();
         Array.Sort(sorted);
         string sortedWord = new string(sorted);

         if (!map.ContainsKey(sortedWord))
         {
             map[sortedWord] = new List<string>();  
         }
         map[sortedWord].Add(str);
     }

     return map.Select(x=>x.Value).ToList();

 }
}
