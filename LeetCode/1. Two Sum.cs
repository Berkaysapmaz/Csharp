public class Solution {
    public int[] TwoSum(int[] nums, int target) {
     
        /*Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
You may assume that each input would have exactly one solution, and you may not use the same element twice.
You can return the answer in any order*/
        
        int i;                                              
        
        for(i = 0;i<nums.Length;i++)
        {
            for(int j=i+1;j<nums.Length;j++)
            {
                if(nums[i]+nums[j]==target){
                    
                    return new int[2]{i,j};
                }  
                    
            }
        }
         return null;
    }
}