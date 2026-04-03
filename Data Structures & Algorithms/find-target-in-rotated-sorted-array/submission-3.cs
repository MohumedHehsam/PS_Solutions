public class Solution {
     public int Search(int[] ar, int target)
 {
     int l = 0, r = ar.Length - 1,m=(l+r)/2;
     while (l <= r)
     {
         if (ar[m] == target)
             return m;
         if (ar[l] < ar[m] && ar[m] < ar[r])
         {
             if (target > ar[m])
                 l = m + 1;
             else
                 r = m - 1;
         }
         else if (ar[m] < ar[l])
         {
             if (target > ar[m] && target <= ar[r])
                 l = m + 1;
             else
                 r = m - 1;
         }
         else
         {
             if (target >= ar[l] && target < ar[m])
                 r = m - 1;
             else
                 l= m + 1;
         }

         m=(l+r)/2;
     }
      return ar[m] == target ? m : -1;
 }
}
