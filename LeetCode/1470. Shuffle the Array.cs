public class Solution {
    public int[] Shuffle(int[] nums, int n) {
        
              /*Given the array nums consisting of 2n elements in the form [x1,x2,...,xn,y1,y2,...,yn].

Return the array in the form [x1,y1,x2,y2,...,xn,yn].*/
      
            int[] sayi = new int[nums.Length];
            int x=0;  
            int i=0;
                while(x < nums.Length)
                {
                  sayi[x]=nums[i];
                  i +=n;
                  x++;
                      if(i > nums.Length -1)
                      {
                        i = i - nums.Length +1;
                      }
                }
              return sayi;
    }         
}