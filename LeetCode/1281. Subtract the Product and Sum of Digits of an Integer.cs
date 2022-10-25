public class Solution {
    public int SubtractProductAndSum(int n) {
        
        /*Given an integer number n, return the difference between the product of its digits and the sum of its digits.*/
        
        int sum =0;
        int prd=1;
        int b;
        
        
        while(n>0)
        {
            b = n%10;
            sum =sum +b;
            prd =prd *b;
            n=n/10;
        }
        return prd-sum;
    }
}