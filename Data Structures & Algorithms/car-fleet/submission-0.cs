public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        int n = position.Length;
        if (n == 0) return 0;

        // Pair position with time
        var cars = new List<(int pos, double time)>();
        for (int i = 0; i < n; i++) {
            double time = (double)(target - position[i]) / speed[i];
            cars.Add((position[i], time));
        }

        // Sort by position descending
        cars.Sort((a, b) => b.pos.CompareTo(a.pos));

        Stack<double> stack = new Stack<double>();

        foreach (var car in cars) {
            if (stack.Count == 0 || car.time > stack.Peek()) {
                // New fleet
                stack.Push(car.time);
            }
            // Otherwise merges into fleet ahead
        }

        return stack.Count;
    }
}
