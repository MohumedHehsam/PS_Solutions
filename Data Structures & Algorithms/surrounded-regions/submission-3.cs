public class Solution
{
    static int r, c;
    public void Solve(char[][] board)
    {
        r = board.GetLength(0);
        c = board[0].Length;
        bool[,] visited = new bool[r, c];

        for (int i = 0; i < r; i++)
        {
            DFS(board, i, 0, visited);
            DFS(board, i, c - 1, visited);
        }

        for (int j = 0; j < c; j++)
        {
            DFS(board, 0, j, visited);
            DFS(board, r - 1, j, visited);
        }

        for (int i = 0; i < r; i++)
            for (int j = 0; j < c; j++)
                if (board[i][j] == 'O')
                    board[i][j] = 'X';
                else if (board[i][j] == 'T')
                    board[i][j] = 'O';


    }

    private void DFS(char[][] board, int i, int j, bool[,] visited)
    {
        if (i >= r || i < 0 || j < 0 || j >= c)
            return;

        if (board[i][j] == 'X' || visited[i, j])
            return;
        visited[i, j] = true;
        board[i][j] = 'T';
        DFS(board, i + 1, j, visited);
        DFS(board, i - 1, j, visited);
        DFS(board, i, j + 1, visited);
        DFS(board, i, j - 1, visited);
    }
}
