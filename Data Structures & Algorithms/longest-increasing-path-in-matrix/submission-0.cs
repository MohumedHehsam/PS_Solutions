public class Solution
{
    public int LongestIncreasingPath(int[][] matrix)
    {
        int l1 = matrix.Length, l2 = matrix[0].Length;
        int?[,] dp = new int?[l1, l2];

        int max = 0;
        for (int i = 0; i < l1; i++)
        {
            for (int j = 0; j < l2; j++)
            {

                max = Math.Max(max, DFS(matrix, i, j, new HashSet<(int i, int j)>(), l1, l2));

            }
        }

        return max;

    }
    private int DFS(int[][] matrix, int i, int j, HashSet<(int i, int j)> path, int l1, int l2)
    {
        if (path.Contains((i, j)))
            return 0;

        path.Add((i, j));
        int max = 0;

        if (i > 0 && matrix[i - 1][j] > matrix[i][j])
        {
            max = Math.Max(max, DFS(matrix, i - 1, j, path, l1, l2));
        }
        if (j > 0 && matrix[i][j - 1] > matrix[i][j])
        {
            max = Math.Max(max, DFS(matrix, i, j - 1, path, l1, l2));
        }

        if (i + 1 < l1 && matrix[i + 1][j] > matrix[i][j])
        {
            max = Math.Max(max, DFS(matrix, i + 1, j, path, l1, l2));
        }

        if (j + 1 < l2 && matrix[i][j + 1] > matrix[i][j])
        {
            max = Math.Max(max, DFS(matrix, i, j + 1, path, l1, l2));
        }

        path.Remove((i, j));
        return max + 1;
    }
}