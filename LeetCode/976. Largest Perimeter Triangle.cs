public class Solution {
    public int LargestPerimeter(int[] nums) {
        
        Array.Sort(nums);
       
        /*Given an integer array nums, return the largest perimeter of a triangle with a non-zero area, formed from three of these lengths. If it is impossible to form any triangle of a non-zero area, return 0.*/
        
         for(int i=nums.Length-1; i>1; i--){
            int a = nums[i];
            int b = nums[i-1];
            int c = nums[i-2];

            if(a+b>c && a+c>b && b+c>a){
                return a+b+c;
            }
        }
        
        return 0;
        
         
    }
}