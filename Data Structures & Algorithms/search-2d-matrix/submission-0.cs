public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {

        int rows = matrix.Length;
        int cols = matrix[0].Length;

        int left = 0;
        int right = (rows * cols) - 1;

        while(left <= right)
        {
            int mid = left + (right - left) / 2; // Find Mid

            // use this mid to find the value in matrix - Apply formula
            int row = mid / cols;
            int col = mid % cols;

            int value = matrix[row][col];

            if(value == target)
            {
                return true;
            }
            else if (value > target)
            {
                right = mid - 1;   
            }
            else
            {
                left = mid + 1;
            }
        }
        return false;
    }
}
