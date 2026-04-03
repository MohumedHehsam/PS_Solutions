public class Solution
{
    public int Change(int amount, int[] coins)
    {
        if (amount <= 0)
            return 1;
        int[,] dp = new int[amount + 1, coins.Length];

        for (int i = 0; i <= amount; i++)
            for (int j = 0; j < coins.Length; j++)
                dp[i, j] = -1;

        for (int i = 0; i < coins.Length; i++)
            dp[0, i] = 1;

        return CountChangeMethods(amount, coins, dp, 0);
    }

    int CountChangeMethods(int amount, int[] coins, int[,] dp, int index)
    {
        if (amount < 0)
            return 0;
        else if (dp[amount, index] != -1)
            return dp[amount, index];

        int res = 0;
        for (int i = index; i < coins.Length; i++)
        {
            res += CountChangeMethods(amount - coins[i], coins, dp, i);
        }

        dp[amount, index] = res;
        return res;
    }
}




