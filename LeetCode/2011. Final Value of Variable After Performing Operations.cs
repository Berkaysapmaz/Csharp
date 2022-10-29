public class Solution {
    public int FinalValueAfterOperations(string[] nums) {
      /*There is a programming language with only four operations and one variable X:
++X and X++ increments the value of the variable X by 1.
--X and X-- decrements the value of the variable X by 1.
Initially, the value of X is 0.
Given an array of strings operations containing a list of operations, return the final value of X after performing all the operations.*/ 
      
      int count = 0;
        int i = 0;
          while(i< nums.Length){
            if(nums[i] == "++X" || nums[i] == "X++")
                  {
                    count++;
                    i++;
                  }
          else if(nums[i] == "--X" || nums[i] == "X--")
                  {
                    count--;
                    i++;
                  
                  }  
              }return count;
    }       
}