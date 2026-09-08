public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) {
            return false;
        }

        const char FirstLetter = 'a';

        var counts = new int[26];

        for (var i = 0; i < s.Length; ++i) {
            ++counts[s[i] - FirstLetter];
            --counts[t[i] - FirstLetter];
        }

        for (var i = 0; i < counts.Length; ++i) {
            if (counts[i] is not 0) {
                return false;
            }
        }

        return true;
    }
}
