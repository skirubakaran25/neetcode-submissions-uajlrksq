public class Solution {
    public int RemoveElement(int[] nums, int val) {

        int read = 0;
        int write = 0;
        while(read < nums.Length)
        {
            if(nums[read] != val)
            {
                nums[write] = nums[read];
                write++;
            }
            read++; 
        }
        
        return write;
    }
}