public class Solution {
   public bool SearchMatrix(int[][] ar, int target) 
    { 
        int row=ar.Length,col=ar[0].Length;
        int l=0,r=row-1,mid_row=(l+r)/2;
        while(l<=r)
        {
            if(ar[mid_row][0] > target)
            r=mid_row-1;
            
            else if (ar[mid_row][col-1] < target)
            l=mid_row+1;
            
            else
            break;
            
            mid_row=(l+r)/2;
        }
        l=0; r=col-1;
        int[] mid_ar=ar[mid_row];
        int indx=Array.BinarySearch<int>(mid_ar,target);
        
        return (indx<0)?false:true;        
    }
}
