public class Solution {
    public int[] TwoSum(int[] numbers, int target)
{

    Dictionary<int, int> dict = new Dictionary<int, int>();
    for (int i = 0; i < numbers.Length; i++)
    {
        int complement = target - numbers[i];

        if (dict.ContainsKey(complement))
        {
            return [dict[complement], i+1];
        }
        dict[numbers[i]] = i + 1;
    }

    return [];
}
}
