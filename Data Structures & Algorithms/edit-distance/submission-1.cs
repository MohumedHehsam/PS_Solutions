public class Solution
{
    public int MinDistance(string s1, string s2)
    {
        int?[,] dp = new int?[s1.Length + 1, s2.Length + 1];
        dp[s1.Length, s2.Length] = 0;
        return DFS(s1, s2, 0, 0, dp);
    }

    int DFS(string s1, string s2, int i, int j, int?[,] dp)
    {

        while (i < s1.Length && j < s2.Length && s1[i] == s2[j])
        {
            i++;
            j++;
        }

        if (dp[i, j] != null)
            return (int)dp[i, j]!;

        int minOps = int.MaxValue;

        if (i < s1.Length)
            //Deleting from s1
            minOps = Math.Min(minOps, DFS(s1, s2, i + 1, j, dp));
        if (i < s1.Length && j < s2.Length)
            //change to s1
            minOps = Math.Min(minOps, DFS(s1, s2, i + 1, j + 1, dp));
        if (j < s2.Length)
            //Insert to s1
            minOps = Math.Min(minOps, DFS(s1, s2, i, j + 1, dp));

        dp[i, j] = minOps + 1;
        return minOps + 1;
    }
}

