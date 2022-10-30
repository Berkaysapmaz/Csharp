public class Solution {
    public int AverageValue(int[] nums) {
              
              /*Given an integer array nums of positive integers, return the average value of all even integers that are divisible by 3.
Note that the average of n elements is the sum of the n elements divided by n and rounded down to the nearest integer.*/  
      
              int sum=0;
              int count=0;
              foreach(int i in nums)
              {
                if(i%6 == 0)
                {sum+= i;
                    count++;
                }
                
              }
              if(sum == 0)
              {
                return 0;
              }
              return sum/count;
    }
}