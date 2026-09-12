public class Solution {
    private HashSet<int> invalidNumbers;

    public bool IsHappy(int n) {
        invalidNumbers = new HashSet<int>();

        while (true) {
            var sum = CalculateSum(n);
            if (sum is 1) {
                return true;
            }

            if (invalidNumbers.Contains(sum)) {
                return false;
            }

            invalidNumbers.Add(sum);
            n = sum;
        }
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