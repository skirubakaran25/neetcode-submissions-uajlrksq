public class Solution {
    public bool hasDuplicate(int[] nums) {

        HashSet<int> hs = new HashSet<int>();

        foreach(int element in nums)
        {
            if(hs.Contains(element))
            {
                return true;
            }
            hs.Add(element);
        }

        return false;
        
    }
}