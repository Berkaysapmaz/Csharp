public class Solution {
    public bool IsToeplitzMatrix(int[][] matrix) {
        /*Given an m x n matrix, return true if the matrix is Toeplitz. Otherwise, return false.

A matrix is Toeplitz if every diagonal from top-left to bottom-right has the same elements.*/
      for(int i=0; i < matrix.Length-1; i++)
      {
        if(!matrix[i][..^1].SequenceEqual(matrix[i + 1][1..])) return false;
      }
          return true;
    }
}