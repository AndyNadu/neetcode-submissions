public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        var prev = cost[0];
        var current = cost[1];

        for (var i = 2; i < cost.Length; ++i) {
            var next = 1 + Math.Min(prev, current);
            prev = current;
            current = next;
        }

        return current;
    }
}