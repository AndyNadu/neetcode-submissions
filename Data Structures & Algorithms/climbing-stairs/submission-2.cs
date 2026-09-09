public class Solution {
    public int ClimbStairs(int n) {     
        if (n <= 2) {
            return n;
        }
        
        var first = 1;
        var second = 2;

        for (int i = 2; i < n; ++i) {
            var third = first + second;
            first = second;
            second = third;
        }

        return second;
    }
}