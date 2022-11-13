public class Solution {
    public string ReverseWords(string s) {
       return s = String.Join(" ", s.Split(' ', StringSplitOptions.RemoveEmptyEntries).Reverse());
    }
}