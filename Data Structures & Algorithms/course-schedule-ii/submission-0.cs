


public class Solution
{
    public int[] FindOrder(int numCourses, int[][] prerequisites)
    {
        Dictionary<int, List<int>> crs = new(numCourses);
        for (int i = 0; i < numCourses; i++)
            crs.Add(i, new List<int>());

        foreach (var item in prerequisites)
            crs[item[0]].Add(item[1]);

        var res = new List<int>();
        HashSet<int> path = new();
        HashSet<int> visited = new();

        for (int i = 0; i < numCourses; i++)
        {
            if (visited.Count == numCourses)
                break;
            else if (visited.Contains(i))
                continue;
            else if (!DFS(crs, visited, new HashSet<int>(), res, i))
                return new int[0];
        }
        return res.ToArray();
    }

    private bool DFS(Dictionary<int, List<int>> crs, HashSet<int> visited, HashSet<int> path, List<int> res, int crnt)
    {
        if (path.Contains(crnt))
            return false;

        path.Add(crnt);

        foreach (var next in crs[crnt])
            if (!DFS(crs, visited, path, res, next))
                return false;

        if (!visited.Contains(crnt))
        {
            res.Add(crnt);
            visited.Add(crnt);
        }

        path.Remove(crnt);
        return true;
    }

}