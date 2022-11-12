public class Solution {
    public int DistinctAverages(int[] nums) {
      Array.Sort(nums);
      var numbersList = nums.ToList();
      List<double> nbList = new List<double>();
      for(int i=0; i<nums.Length/2;i++){
      int max = numbersList.Max();
      int min = numbersList.Min();
      numbersList.Remove(min);
      //Console.WriteLine(numbersList.Count());
      numbersList.Remove(max);
      //Console.WriteLine(numbersList.Count());
      double avg = (max+min)/2.0;
      Console.WriteLine(avg);
          if(!nbList.Contains(avg)){
                  nbList.Add(avg);
          
          }
      }
      return nbList.Count();
    }
}