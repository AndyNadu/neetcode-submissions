public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) {
            return false;
        }

        const char FirstLetter = 'a';

        var firstWordLettersCount = new int[26];
        var secondWordLettersCount = new int[26];

        for (var i = 0; i < s.Length; ++i) {
            ++firstWordLettersCount[s[i] - FirstLetter];
            ++secondWordLettersCount[t[i] - FirstLetter];
        }

        for (var i = 0; i < firstWordLettersCount.Length; ++i) {
            if (firstWordLettersCount[i] != secondWordLettersCount[i]) {
                return false;
            }
        }

        return true;
    }
}
