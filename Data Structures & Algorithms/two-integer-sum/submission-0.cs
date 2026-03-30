public class Solution
{
    public int[] TwoSum(int[] nums, int target)
 {

     Dictionary<int, int> map = new Dictionary<int, int>();

     if (nums.Length >= 0)
     {
         for (int i = 0; i < nums.Length; i++)
         {
             int complement = target - nums[i];
             if (map.ContainsKey(complement))
             {
                 return [map[complement], i];
             }
             map[nums[i]] = i;
         }
     }

     return [];
 }
}
