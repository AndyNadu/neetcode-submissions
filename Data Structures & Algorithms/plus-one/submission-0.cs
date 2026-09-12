public class Solution {
    public int[] PlusOne(int[] digits) {
        var needsIncremental = 1;
        for (var i = digits.Length - 1; i >= 0; i--) {
            var shouldKeepIncrementing = false;

            if (needsIncremental is 1) {
                if (digits[i] + needsIncremental is 10) {
                    digits[i] = 0;
                    shouldKeepIncrementing = true;
                }
                else {
                    ++digits[i];
                }
            }

            if (shouldKeepIncrementing is false) {
                needsIncremental = 0;
            }
        }       

        return needsIncremental is 1
            ? [1, ..digits]
            : digits;
    }
}