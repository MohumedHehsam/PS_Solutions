public class Solution {
    public bool ValidTree(int n, int[][] edges) 
    {
        if (edges.Length != n - 1) return false;
        Dictionary<int,List<int>> map = new Dictionary<int, List<int>>();
        for(int i=0; i<n; i++) map.Add(i, new List<int>());
        foreach(var pair in edges)
        {
            map[pair[0]].Add(pair[1]);
            map[pair[1]].Add(pair[0]);
        }
        
        bool[] visited = new bool[n];
        if(!DFS(map, 0, -1, visited))
            return false;
            
        foreach(bool v in visited) if(!v) return false;
        
        return true;
    }

    private bool DFS(Dictionary<int, List<int>> map, int i, int parent, bool[] path)
    {        
        if(path[i])
        return false;

        path[i]=true;
        var neighbours= map[i];
        foreach(var item in neighbours)
        {
            if(item==parent)
            continue;
            if(!DFS(map,item,i,path))
            return false;
        }
        return true;
    }
}