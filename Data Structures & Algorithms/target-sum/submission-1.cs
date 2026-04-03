public class Solution
{
    public int FindTargetSumWays(int[] nums, int target)
    {
        int maxLen = nums.Sum();
        int[,] dp = new int[2 * maxLen + 5, nums.Length];
        for (int i = 0; i < dp.GetLength(0); i++)
            for (int j = 0; j < dp.GetLength(1); j++)
                dp[i, j] = -1;
        return DFS(nums, dp, 0, target, 0, maxLen);

    }
    int DFS(int[] nums, int[,] dp, int sum, int target, int i, int maxLen)
    {
        if (i == nums.Length)
        {
            if (sum == target)
                return 1;
            else
                return 0;
        }
        if (dp[sum + maxLen, i] != -1)
            return dp[sum + maxLen, i];

        int count = 0;

            count += DFS(nums, dp, sum + nums[i], target, i + 1, maxLen);
            count += DFS(nums, dp, sum - nums[i], target, i + 1, maxLen);
            
        dp[sum + maxLen, i] = count;
        return count;
    }
}
