public class Solution {
    
  /*You are given two positive integers n and target.

An integer is considered beautiful if the sum of its digits is less than or equal to target.

Return the minimum non-negative integer x such that n + x is beautiful. The input will be generated such that it is always possible to make n beautiful.*/
  
        public long first(long n)
          {   long sum =0;
            while(n > 0)
                    {
                      long b = n%10;
                      sum = sum+b;
                      n= n/10;
                    }
            return sum;
          }
          public long MakeIntegerBeautiful(long n, int target) {        
              int x =1;
              long sum = first(n);
                    if(sum <= target)
                    {
                      return 0;
                    }

                        while(true)
                        { long sumd = first(n+x);
                            if(sumd <= target)
                                  {
                                    return x;
                                  }
                             x++;
                        }

            return 1;
          }
      }