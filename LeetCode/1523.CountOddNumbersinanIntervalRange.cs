public class Solution {
    public int CountOdds(int low, int high) {
        
        /*Given two non-negative integers low and high. Return the count of odd numbers between low and high (inclusive).*/
        
        if(high%2==0 && low%2==0)
        {
            return(high-low)/2;
        }    
        
    
            return(high-low)/2+1;
        
        
        
    }
}