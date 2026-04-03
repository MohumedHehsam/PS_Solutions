public class Solution {
   public int MaxProfit(int[] ar)
  {
      int min = ar[0], max = ar[0],res=0;
      for (int i = 0; i < ar.Length; i++)
      {
          if (ar[i] < min)
          { min = ar[i]; max=ar[i]; }
          else if(ar[i] > max)
          {
              max=ar[i];
                              res = res>(max-min)?res:max-min ;
          }
      }
      return res;

  }
}
