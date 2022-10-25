public class Solution {
    public double Average(int[] salary) {
        
        /*You are given an array of unique integers salary where salary[i] is the salary of the ith employee.
Return the average salary of employees excluding the minimum and maximum salary. Answers within 10-5 of the actual answer will be accepted.*/
        
        int min = salary[0];
        int max = salary[0];
        int sum = 0;
        foreach(var num in salary)
        {
            if(num > max)
                max = num;
            if(num < min)
                min = num;
            sum+=num;
        }
        sum-=(min+max);
        return (double)sum/(salary.Length-2);
    }
}