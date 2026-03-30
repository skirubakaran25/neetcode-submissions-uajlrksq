public class Solution {
    public int LongestConsecutive(int[] nums) {

        // having them in hashset removed duplicate elements from the array.
        HashSet<int> hs = new HashSet<int>(nums);

        int longest = 0;
        foreach(int num in hs)
        {
            if(!hs.Contains(num-1))
            {   
                int counter = 1;
                int current = num;

                while(hs.Contains(current+1))
                {
                    counter++;
                    current++;
                }

                longest = Math.Max(longest,counter);
            }
        }
        return longest;
    }
}
