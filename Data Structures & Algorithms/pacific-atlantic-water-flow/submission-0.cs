
public class Solution
{
    static int r, c;
    public List<List<int>> PacificAtlantic(int[][] heights)
    {
         r = heights.GetLength(0);
         c = heights[0].Length;
        bool[,] isPacific = new bool[r, c];
        bool[,] isAtl = new bool[r, c];
        bool[,] visitedPac = new bool[r, c];
        bool[,] visitedAtl = new bool[r, c];
        List<List<int>> res=new();

        for (int i = 0; i < r; i++)
        {
            isPacific[i, 0] = true;
            isAtl[i, c - 1] = true;
            BFS(heights, i, 0, visitedPac, isPacific);
            BFS(heights, i, c - 1, visitedAtl, isAtl);
        }


        for (int j = 0; j < c; j++)
        {
            isPacific[0, j] = true;
            isAtl[r - 1, j] = true;
            BFS(heights, 0, j, visitedPac, isPacific);
            BFS(heights, r - 1, j, visitedAtl, isAtl);
        }

        for (int i = 0; i < r; i++)
            for (int j = 0; j < c; j++)
                if (isAtl[i, j] && isPacific[i, j])
                    res.Add(new List<int>(){i,j});

        return res;


    }

    void BFS(int[][] heights, int i, int j, bool[,] visited, bool[,] isGrid)
    {
        (int, int)[] dir =
        {
            (1,0),
            (-1,0),
            (0,1),
            (0,-1)
        };

        var q = new Queue<(int x, int y)>();
        q.Enqueue((i, j));
        while (q.Count > 0)
        {
            var crnt = q.Dequeue();
            if (visited[crnt.x, crnt.y])
                continue;

            visited[crnt.x, crnt.y] = true;
            foreach (var d in dir)
            {
                (int x, int y) point = (d.Item1 + crnt.x, d.Item2 + crnt.y);
                if (isValid(point.x, point.y) && heights[point.x][point.y] >= heights[crnt.x][crnt.y])
                {
                    isGrid[point.x,point.y] = true;
                    q.Enqueue(point);
                }
            }


        }

    }

    private bool isValid(int i, int j)
    {
        if (i >= 0 && i < r)
            if (j >= 0 && j < c)
                return true;
        return false;
    }
}
