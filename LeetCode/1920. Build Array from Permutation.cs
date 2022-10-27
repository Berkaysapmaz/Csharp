public class Solution {
    public int[] BuildArray(int[] nums) {
        
        /*Given a zero-based permutation nums (0-indexed), build an array ans of the same length where ans[i] = nums[nums[i]] for each 0 <= i < nums.length and return it.
A zero-based permutation nums is an array of distinct integers from 0 to nums.length - 1 (inclusive).*/
        
        int[] ans = new int[nums.Length];
        int i = 0;
        while(i < nums.Length)
        {
            ans[i] = nums[nums[i]];
            i++;
        }
        return ans;
    }
}