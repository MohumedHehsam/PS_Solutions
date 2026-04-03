public class Solution
{
    public bool IsInterleave(string s1, string s2, string s3)
    {
        if (s1.Length + s2.Length != s3.Length)
            return false;
        bool?[,] dp = new bool?[s1.Length + 1, s2.Length + 1];

        return DFS(s1, s2, s3, 0, 0, dp);
    }

    bool DFS(string s1, string s2, string s3, int i, int j, bool?[,] dp)
    {
        if (i == s1.Length && j == s2.Length)
            return true;

        if (dp[i, j] != null)
            return (bool)dp[i, j]!;

        int k = i + j;
        bool Reached = false;
        if (i < s1.Length && s3[k] == s1[i] && DFS(s1, s2, s3, i + 1, j, dp))
            Reached = true;

        if (j < s2.Length && s3[k] == s2[j] && DFS(s1, s2, s3, i, j + 1, dp))
            Reached = true;

        dp[i, j] = Reached;

        return Reached;
    }
}