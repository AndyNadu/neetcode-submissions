public class Solution {
    public int[] CountBits(int n) {
        var result = new int[n + 1];

        for (var i = 1; i <= n; ++i) {
            result[i] = result[i & (i - 1)] + 1;
        }

        return result;
    }
}