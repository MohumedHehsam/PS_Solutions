public class Solution
{
    public int LongestCommonSubsequence(string t1, string t2)
    {
        int l1 = t1.Length, l2 = t2.Length;

        int[,] dp = new int[l1 + 1, l2 + 1];

        for (int i = 1; i <= l1; i++)
        {
            for (int j = 1; j <= l2; j++)
            {
                if (t1[i - 1] == t2[j - 1])
                    dp[i, j] = dp[i - 1, j - 1] + 1;
                else
                    dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
            }

        }
        return dp[l1, l2];
    }
}


