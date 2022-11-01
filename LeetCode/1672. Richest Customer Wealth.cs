public class Solution {
    public int MaximumWealth(int[][] accounts) {
          
      /*You are given an m x n integer grid accounts where accounts[i][j] is the amount of money the i​​​​​​​​​​​th​​​​ customer has in the j​​​​​​​​​​​th​​​​ bank. Return the wealth that the richest customer has.
A customer's wealth is the amount of money they have in all their bank accounts. The richest customer is the customer that has the maximum wealth.*/
          int[] Sum = new int[accounts.Length];      
          for(int x =0; x< accounts.Length; x++)
          {
            int sum = accounts[x].Sum();
            Sum[x]=sum;
          }
            Array.Sort(Sum);
        return Sum[accounts.Length-1];
    }
}