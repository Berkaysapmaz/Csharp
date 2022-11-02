public class Solution {
    public int[] FindBall(int[][] grid) {
      /*You have a 2-D grid of size m x n representing a box, and you have n balls. The box is open on the top and bottom sides.

Each cell in the box has a diagonal board spanning two corners of the cell that can redirect a ball to the right or to the left.

A board that redirects the ball to the right spans the top-left corner to the bottom-right corner and is represented in the grid as 1.
A board that redirects the ball to the left spans the top-right corner to the bottom-left corner and is represented in the grid as -1.
We drop one ball at the top of each column of the box. Each ball can get stuck in the box or fall out of the bottom. A ball gets stuck if it hits a "V" shaped pattern between two boards or if a board redirects the ball into either wall of the box.

Return an array answer of size n where answer[i] is the column that the ball falls out of at the bottom after dropping the ball from the ith column at the top, or -1 if the ball gets stuck in the box.*/
      
      int n =grid[0].Length;
      int m =grid.Length;
      int[] arr= new int[n];
      int row=0;
      int column=0;
      for(int j=0;j<n;j++)
      { 
          int tempRow=row;
          int tempColumn=column;
            for(int i=0; i <m;i++)
            {
              if(grid[tempRow][tempColumn]==1)
              {
                if( tempColumn+1 >= 0 && tempColumn+1 <n && grid[tempRow][tempColumn+1]==1)
                {
                  tempRow+=1;
                  tempColumn+=1;
                }  
                else
                {
                  tempColumn= -1;
                  break;
                }
              }
              else if(grid[tempRow][tempColumn]==-1)
              {
                if( tempColumn-1 >= 0 && tempColumn-1 <n && grid[tempRow][tempColumn-1]==-1)
                {
                  tempRow+=1;
                  tempColumn-=1;
                }
                else
                {
                  tempColumn= -1;
                  break;
                }
              }
            }
            arr[j]=tempColumn; 
            column+=1;
      }
    
        return arr;
    
    }
}