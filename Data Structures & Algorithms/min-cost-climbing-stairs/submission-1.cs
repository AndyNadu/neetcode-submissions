public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        var prev = cost[0];
        var current = cost[1];

        for (var i = 2; i < cost.Length - 1; ++i) {
            var next = cost[i] + Math.Min(prev, current);
            prev = current;
            current = next;
        }

        return current;
    }
}