public class Solution {
    public int[] ApplyOperations(int[] nums) {
          /*You are given a 0-indexed array nums of size n consisting of non-negative integers.

You need to apply n - 1 operations to this array where, in the ith operation (0-indexed), you will apply the following on the ith element of nums:

If nums[i] == nums[i + 1], then multiply nums[i] by 2 and set nums[i + 1] to 0. Otherwise, you skip this operation.
After performing all the operations, shift all the 0's to the end of the array.

For example, the array [1,0,2,0,0,1] after shifting all its 0's to the end, is [1,2,1,0,0,0].
Return the resulting array.

Note that the operations are applied sequentially, not all at once.*/
          int n= nums.Length-1;
          int i=0;
          int[] arr = new int[nums.Length];
          int count=0;
          
          while(i<n)
          {
            Console.WriteLine(arr);
            if(nums[i]==nums[i+1])
            {
              nums[i]=nums[i]*2;
              nums[i+1]=0;  
            } 
                i++;
          }  
          i=0;
          int j =0;
          while(i<nums.Length)
          {
            if(nums[i]==0)
            {
              count++;
            }
            else
            {
              arr[j]=nums[i];
              Console.WriteLine(arr);
              j++;
            }
            i++;
           
          }
          i=0;
          
          while(i<count)
          {
             arr[j]=0;
             i++;  
          }
        return arr;
    }
}