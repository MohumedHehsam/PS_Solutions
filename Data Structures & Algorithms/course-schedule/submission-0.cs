

public class Solution
{
    public bool CanFinish(int numCourses, int[][] prerequisites)
    {
        Dictionary<int, List<int>> crs = new(numCourses);
        for (int i = 0; i < numCourses; i++)
            crs.Add(i, new List<int>());

        foreach (var item in prerequisites)
            crs[item[0]].Add(item[1]);

        HashSet<int> visited= new();
        for (int i = 0; i < numCourses; i++)
            if (ContainsLoop(crs, i, new HashSet<int>(),visited))
                return false;

        return true;
    }

    private bool ContainsLoop(Dictionary<int, List<int>> crs, int crnt, HashSet<int> path, HashSet<int> visited)
    {
        if (path.Contains(crnt))
            return true;

        if(visited.Contains(crnt))
        return false;
        
        path.Add(crnt);

        foreach (var next in crs[crnt])
            if (ContainsLoop(crs, next, path,visited))
                return true;

        visited.Add(crnt);

        path.Remove(crnt);
        return false;
    }

}