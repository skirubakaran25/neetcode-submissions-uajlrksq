public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs)
{
    Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();

    for (int i = 0; i < strs.Length; i++)
    {
        char[] sortArr = strs[i].ToCharArray();
        Array.Sort(sortArr);

        string sortedString = new string(sortArr);
        if (!map.ContainsKey(sortedString))
        {
            map[sortedString] = new List<string>() { strs[i] };
            continue;
        }

        map[sortedString].Add(strs[i]);
    }

    return map.Values.ToList();
}
}
