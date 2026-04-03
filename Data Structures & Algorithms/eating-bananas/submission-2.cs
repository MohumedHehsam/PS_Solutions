public class Solution {
public int MinEatingSpeed(int[] piles, int h) {
         int l=1,r=Max(piles),m=(l+r)/2;
         int res=r;
         while(l<=r)
         {
            int sum=0;
            foreach(var item in piles)
            {
                sum+=(int)Math.Ceiling(1.0*item/m);
            }
            if(sum>h)
            {
                l=m+1;
            }
            else 
            {
                res=Math.Min(res,m);
                r=m-1;
            }

            m=(l+r)/2;
         }  
         return res;
    }

    private int Max(int[] piles)
    {
        int max=piles[0];
        foreach(var item in piles)
        max=Math.Max(item,max);
        return max;
    }
}
