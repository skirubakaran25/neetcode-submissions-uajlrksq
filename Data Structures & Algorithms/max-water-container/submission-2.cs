public class Solution {
    public int MaxArea(int[] heights) {

        int left = 0;
        int right = heights.Length - 1;

        int maxArea = 0;
        
        while(left < right)
        {
            int minHeight = Math.Min(heights[left], heights[right]);  // find minimum height

            int width = right-left;
            int area = minHeight * width;

            maxArea = Math.Max(maxArea, area);

            if(heights[left] < heights[right]) // move a pointer hoping for a shorter bar
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        return maxArea;
    }
}
