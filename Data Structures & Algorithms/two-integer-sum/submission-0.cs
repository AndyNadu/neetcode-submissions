public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var numberPositions = new Dictionary<int, int>();
        numberPositions.Add(nums[0], 0);

        for(var i = 1; i < nums.Length; ++i) {
            if (numberPositions.ContainsKey(target - nums[i])) {
                var complementaryIndex = numberPositions[target - nums[i]];
                if (complementaryIndex == i) {
                    continue;
                }

                if (complementaryIndex < i) {
                    (complementaryIndex, i) = (i, complementaryIndex);
                }

                return [i, complementaryIndex];
            }
        }

        return [];
    }
}