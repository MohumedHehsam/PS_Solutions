public class Solution {
  public int MaxArea(int[] heights) {
        int i=0;
        int j=heights.Length-1;
        int maxArea=0;
        while(i<j)
        {
            int crnt=Math.Min(heights[i],heights[j]);
            if(crnt*(j-i)>maxArea)
            {
                maxArea=crnt*(j-i);
            }
            if(crnt==heights[j])
            j--;
            else
            i++;
        }
        return maxArea;
    }
}
