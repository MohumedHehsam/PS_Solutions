public class Solution
{
    public int SingleNumber(int[] nums)
    {
        return nums.Aggregate((prev,crnt)=>prev^crnt);
    }
}