public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {

        var cars = new List<(int position, double time)>();

        // Find the position and the timings
        for(int i = 0 ; i < position.Length; i++)
        {
            double time = (double)(target - position[i]) / speed[i]; // double division - not integer division
            cars.Add((position[i], time));
        }

        // Sort by position descending (so that we need to figure out the cars thats position are close to the target)
        cars.Sort((a, b) => b.position.CompareTo(a.position));


        // Compare the current car time with the prev car time.
        Stack<double> stack = new Stack<double>();

        foreach(var item in cars)
        {
            double currTime = item.time;
            
            if(stack.Count == 0 || currTime > stack.Peek())
            {
                stack.Push(item.time);
            }
        }

        return stack.Count;
        
    }
}
