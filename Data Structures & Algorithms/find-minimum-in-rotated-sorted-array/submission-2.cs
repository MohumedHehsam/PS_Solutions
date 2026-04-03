public class Solution {
   public int FindMin(int[] nums) {
        int l=0;
        int r=nums.Length-1;
        int m=(l+r)/2;
        int min = nums[r];
        while(l<=r)
        {
            if(nums[m]>min)
            {
                l=m+1;
            }
            else{
                min=Math.Min(min,nums[m]);
                r=m-1;
            }
            m=(l+r)/2;
        }
        return min;
    }
}
