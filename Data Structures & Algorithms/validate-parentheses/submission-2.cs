public class Solution {
    public bool IsValid(string s) {
        var stack = new Stack<char>();
        var pairs = new Dictionary<char, char> {
            { ')', '(' },
            { ']', '[' },
            { '}', '{' }
        };

        foreach (var ch in s) {
            if (pairs.ContainsKey(ch)) {
                if (stack.IsEmpty() || stack.Pop() != pairs[ch]) {
                    return false;
                }
            }
            else {
                stack.Push(ch);
            }
        }

        return true;
    }
}
