public class Solution
{
    public int MissingNumber(int[] nums)
    {
        int xor = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            xor ^= nums[i];
            xor ^= i + 1;
        }

        return xor ;
    }
}
