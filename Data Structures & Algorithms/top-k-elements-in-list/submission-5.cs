public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {

        Dictionary<int, int> map = new Dictionary<int, int>();

        foreach(int num in nums)
        {
            if(map.ContainsKey(num))
            {
                map[num]++;
            }
            else
            {
                map[num] = 1;
            }
        }

        PriorityQueue<int, int> priorityQueue = new PriorityQueue<int, int>();

        foreach(var item in map)
        {
            priorityQueue.Enqueue(item.Key, item.Value);
            if (priorityQueue.Count > k)
            {
              priorityQueue.Dequeue();
            }
        }

        return priorityQueue.UnorderedItems.Select(x=> x.Element).ToArray();
    }
}
