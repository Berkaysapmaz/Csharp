public class Solution {
    public int ArraySign(int[] nums) {
         
      /*There is a function signFunc(x) that returns:
1 if x is positive.
-1 if x is negative.
0 if x is equal to 0.
You are given an integer array nums. Let product be the product of all values in the array nums.
Return signFunc(product).*/
      
         double sonuc = 1;
         int i =0;
         int product;
            while(i< nums.Length)
            {
              sonuc = nums[i]*sonuc;
              i++;
            }  
            if(sonuc > 0)
            {
              return product = 1;
            }  
            else if(sonuc < 0)
            {
              return product = -1;
            }  
            else
            {
              return product = 0;
            }
      
    }
}