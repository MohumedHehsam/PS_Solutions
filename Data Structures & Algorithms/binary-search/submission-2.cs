public class Solution {
     public int Search(int[] ar, int target) {
        
        int l=0; int r=ar.Length-1;
        while(l<=r)
        {
            int min =(l+r)/2;
            if(ar[min]==target)
            return min;
            else if(ar[r]==target)
            return r;
            else if (ar[min]<target)
            l=min+1;
            else
            r=min-1;
        }
        return -1;
    }
}
