public class Solution {
     public int MinEatingSpeed(int[] piles, int h) {
         int x=0;
        long res;
        do
        {
        res=0;
        x++;
            foreach(var item in piles)
            res+=(int)Math.Ceiling(item*1.0/x);

        }
        while(res>h);
        return x;
    }
}
