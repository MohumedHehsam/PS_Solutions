public class Solution {
   public  bool hasDuplicate(int[] nums) {
        bool [] ar=new bool [1000000];
        for(int i=0;i<nums.Length;i++)
        {
            if(ar[nums[i]+500000]==true)
            return true;
            ar[nums[i]+500000]=true;
        }
        return false;
    }
}
