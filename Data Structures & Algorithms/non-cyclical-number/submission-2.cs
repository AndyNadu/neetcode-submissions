public class Solution {
    public bool IsHappy(int n) {
        var slow = n;
        var fast = CalculateSum(n);

        while (slow != fast && fast != 1) {
            slow = CalculateSum(slow);
            fast = CalculateSum(CalculateSum(fast));
        }

        return fast is 1;
    }

    private int CalculateSum(int n) {
        var sum = 0;

        while (n != 0) {
            var lastDigit = n % 10;
            sum += lastDigit * lastDigit;
            n /= 10;
        }

        return sum;
    }
}