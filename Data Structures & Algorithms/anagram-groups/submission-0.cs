public class Solution {
 public  List<List<string>> GroupAnagrams(string[] strs)
 {
     Dictionary<string, List<string>> ga = new Dictionary<string, List<string>>();

     foreach (var item in strs)
     {
         char[] sort = item.ToCharArray();
         Array.Sort(sort);

         var sortIndex = String.Join("", sort);

         if (!ga.ContainsKey(sortIndex))
         {
             ga[sortIndex] = new List<string>();
         }

         ga[sortIndex].Add(item);
     }

     return ga.Values.ToList();
 }
}
