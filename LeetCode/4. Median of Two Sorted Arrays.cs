
public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        var z = new int[nums1.Length + nums2.Length];
              nums1.CopyTo(z, 0);
              nums2.CopyTo(z, nums1.Length);
              Array.Sort(z);
              int size = z.Length; 
              int mid = size / 2;

              if (size % 2 != 0)
                  return z[mid];

              float value1 = z[mid];
              float value2 = z[mid - 1];
              return (value1 + value2) / 2;
              
    }
}