public class Solution {
    public int[] TopKFrequent(int[] nums, int k)
{
    // Frequency Count Pattern
    Dictionary<int, int> freqCount = new Dictionary<int, int>();

    for(int i = 0; i < nums.Length; i++)
    {
        if (!freqCount.ContainsKey(nums[i]))
        {
            freqCount[nums[i]] = 0;
        }
        freqCount[nums[i]]++;
    }

    // To pick the top k elements - Use PriorityQueue;

    PriorityQueue<int, int> pq = new PriorityQueue<int, int>();

    foreach (var item in freqCount)
    { 
        pq.Enqueue(item.Key, item.Value);
        if (pq.Count > k)
        {
            pq.Dequeue();
        }
    }

    int[] output = new int[k];
    for (int i = 0; i < output.Length; i++)
    {
        output[i] = pq.Dequeue();
    }

    return output;

}
 
}
