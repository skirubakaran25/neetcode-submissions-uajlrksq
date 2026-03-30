public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int ansSize = nums.Length * 2;
        int[] ans = new int[ansSize];

        int j=0;
        for(int n = 0; n < 2; n++)
        {
            for(int i = 0; i < nums.Length ; i++)
            {
                ans[j++] = nums[i];
            }
        }
        return ans;
    }
}