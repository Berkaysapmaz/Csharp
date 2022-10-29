public class Solution {
    public int[] RunningSum(int[] nums) {
           
        /*Given an array nums. We define a running sum of an array as runningSum[i] = sum(nums[0]…nums[i]).
Return the running sum of nums.*/
        
        int sum = 0;
        int i = 0;
        int[] newarr = new int[nums.Length];
        
            while(i < nums.Length)
            {
                sum += nums[i];
                newarr[i] = sum;
                i++;
                
            }
        return newarr;
    }
    
}