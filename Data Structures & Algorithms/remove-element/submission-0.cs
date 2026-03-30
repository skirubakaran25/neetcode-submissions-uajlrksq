public class Solution {
    public int RemoveElement(int[] nums, int val) {

        int read = 0;
        int write = 0;
        int count = 0;
        while(read < nums.Length)
        {
            if(nums[read] != val)
            {
                count++;
                nums[write] = nums[read];
                read++;
                write++;
            }
            else
            {
                read++;
            }
            // while(nums[read] != val && read < nums.Length)
            // {
            //     nums[write] = nums[read];
            //     read++;
            //     write++;
            // }
            // read++;
        }
        
        return count;
    }
}