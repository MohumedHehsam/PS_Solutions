public class Solution
{
    public int CountComponents(int n, int[][] edges)
    {
        int[] parents = new int[n];
        int[] ranks = new int[n];
        Array.Fill(ranks, 1);

        for (int i = 0; i < n; i++)
            parents[i] = i;

        foreach (var pair in edges)
            union(pair[0], pair[1], parents, ranks);

        HashSet<int> parentsCount = new();
        for (int i = 0; i < n; i++)
            parentsCount.Add(find(i, parents));


        return parentsCount.Count();
    }


    int find(int i, int[] parents)
    {
        if (parents[i] == i)
            return i;

        return parents[i] = find(parents[i], parents);
    }
    void union(int i, int j, int[] parents, int[] ranks)
    {
        int pi = find(i, parents);
        int pj = find(j, parents);
        if (ranks[pi] < ranks[pj])
        {
            parents[pi] = pj;
            ranks[pj] += ranks[pi];
        }
        else
        {
            parents[pj] = pi;
            ranks[pi] += ranks[pj];
        }
    }
}
