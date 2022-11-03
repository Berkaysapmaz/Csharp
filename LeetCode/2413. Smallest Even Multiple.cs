public class Solution {
    public int SmallestEvenMultiple(int n) {
          
      /*Given a positive integer n, return the smallest positive integer that is a multiple of both 2 and n.*/
          if(n%2==0)
          {
            return n;
          }
          else
          {
            return n*2;
          }  
    } 
}