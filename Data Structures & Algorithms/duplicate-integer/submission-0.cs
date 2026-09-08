public class Solution {
    public bool hasDuplicate(int[] nums) {
        var foundNumbers = new HashSet<int>();

        foreach (var num in nums) {
            if (foundNumbers.Contains(num)) {
                return true;
            }

            foundNumbers.Add(num);
        }

        return false;
    }
}