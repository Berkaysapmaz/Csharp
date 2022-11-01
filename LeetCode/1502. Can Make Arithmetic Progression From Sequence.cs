public class Solution {
    public bool CanMakeArithmeticProgression(int[] arr) {
            /*A sequence of numbers is called an arithmetic progression if the difference between any two consecutive elements is the same.
Given an array of numbers arr, return true if the array can be rearranged to form an arithmetic progression. Otherwise, return false.*/      
      
            Array.Sort(arr);
            int ki= arr[1]-arr[0];
           for(int i=2;i<arr.Length;i++)
           {
             if(ki!= arr[i]-arr[i-1])
             {
               return false;
             }
              
           }  
              return true;
    }
}