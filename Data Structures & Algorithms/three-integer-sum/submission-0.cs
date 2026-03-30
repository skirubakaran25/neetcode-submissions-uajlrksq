public class Solution {
      public List<List<int>> ThreeSum(int[] nums)
   {
       List<List<int>> results = new List<List<int>>();

       // Sort the array
       Array.Sort(nums);

       // Now we need three pointers
       // Fix 1 item and two pointers
       int len = nums.Length;
       

       // Fix 1 item
       for (int i = 0; i < len; i++)
       {
           // check for duplicate
           if (i > 0 && nums[i] == nums[i - 1]) continue;

           int left = i + 1;
           int right = len - 1;

           // Loop using the left and right
           while (left < right)
           {
               int sum = nums[i] + nums[left] + nums[right];

               if (sum > 0)
               {
                   right--;
               }
               if (sum == 0)
               {
                   results.Add(new List<int> { nums[i], nums[left], nums[right] });
                   left++;
                   right--;

                   // Skip duplicates
                   while (left < right && nums[left] == nums[left - 1]) left++;
                   while (left < right && nums[right] == nums[right + 1]) right--;

               }
               if (sum < 0)
               {
                   left++;
               }
           }            
       }
       return results;
   }
}
