public class Solution {
    public double[] ConvertTemperature(double celsius) {
              
      /*You are given a non-negative floating point number rounded to two decimal places celsius, that denotes the temperature in Celsius.

You should convert Celsius into Kelvin and Fahrenheit and return it as an array ans = [kelvin, fahrenheit].

Return the array ans. Answers within 10-5 of the actual answer will be accepted.*/
        double[] ans = new double[2];
        double Kelv = celsius+ 273.15;
        double Fahr = (celsius*1.80)+32.00;
        ans.SetValue(Kelv,0);
        ans.SetValue(Fahr,1);
      return ans;
    }
}