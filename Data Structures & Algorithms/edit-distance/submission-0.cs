public class Solution
{
    public int MinDistance(string word1, string word2)
    {

        return DFS(word1, word2, 0, 0, 0);
    }

    int DFS(string s1, string s2, int i, int j, int ops)
    {
        if (i == s1.Length && j == s2.Length)
            return ops;
        while (i < s1.Length && j < s2.Length && s1[i] == s2[j])
        {
            i++;
            j++;
        }
        if (i == s1.Length && j == s2.Length)
            return ops;
        int minOps = int.MaxValue;

        if (i < s1.Length)
            //Deleting from s1
            minOps = Math.Min(minOps, DFS(s1, s2, i + 1, j, ops + 1));
        if (i < s1.Length && j < s2.Length)
            //change to s1
            minOps = Math.Min(minOps, DFS(s1, s2, i + 1, j + 1, ops + 1));
        if (j < s2.Length)
            //Insert to s1
            minOps = Math.Min(minOps, DFS(s1, s2, i, j + 1, ops + 1));

        return minOps;
    }
}

