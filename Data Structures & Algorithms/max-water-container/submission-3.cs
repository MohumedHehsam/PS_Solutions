public class Solution {
      public int MaxArea(int[] ar)
     {
        int maxArea=0;
        for(int i=0;i<ar.Length;i++)
        {
            for(int j=i+1;j<ar.Length;j++)
            {
                int min =Math.Min(ar[i],ar[j]);
                maxArea=Math.Max(min*(j-i),maxArea);
            }
        }

      return maxArea;
    }
}
