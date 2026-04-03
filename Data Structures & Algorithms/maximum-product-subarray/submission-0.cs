public class Solution
{
    public int MaxProduct(int[] nums)
    {
        Dictionary<int, (int min, int max)> maxMin = new();
        maxMin.Add(nums.Length - 1, (nums.Last(), nums.Last()));
        int res = nums.Last();
        for (int i = nums.Length - 2; i >= 0; i--)
            res = Math.Max(Dp(nums, maxMin, i), res);

        return res;
    }

    private int Dp(int[] nums, Dictionary<int, (int min, int max)> maxMin, int i)
    {
        int nextMax = maxMin[i + 1].max * nums[i];
        int nextMin = maxMin[i + 1].min * nums[i];
        
        int crntMax = Math.Max(nums[i], Math.Max(nextMax, nextMin));
        int crntMin = Math.Min(nums[i], Math.Min(nextMax, nextMin));
        maxMin.Add(i, (crntMin, crntMax));
        return crntMax;
    }
}