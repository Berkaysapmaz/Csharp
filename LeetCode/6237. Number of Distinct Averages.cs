public class Solution {
    public int DistinctAverages(int[] nums) {
      Array.Sort(nums);
      var numbersList = nums.ToList();
      List<double> nbList = new List<double>();
      for(int i=0; i<nums.Length/2;i++){
      int max = numbersList.Max();
      int min = numbersList.Min();
      numbersList.Remove(min);
      numbersList.Remove(max);
      double avg = (max+min)/2.0;
          if(!nbList.Contains(avg)){
                  nbList.Add(avg);
          
          }
      }
      return nbList.Count();
    }
}