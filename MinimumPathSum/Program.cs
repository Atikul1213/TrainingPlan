public class Program
{
    // link   https://leetcode.com/problems/minimum-path-sum/submissions/1773579894
    public static void Main(string[] args)
    {
        List<List<int>> arr = new List<List<int>>();

        int len = Convert.ToInt32(Console.ReadLine());
    }

    public int MinPathSum(int[][] grid)
    {
        int row = grid.Length;
        int column = grid[0].Length;
        Console.WriteLine("row: " + row + " column:  " + column);
        for (int i = 1; i < column; i++)
        {
            grid[0][i] += grid[0][i - 1];
        }
        for (int i = 1; i < row; i++)
        {
            grid[i][0] += grid[i - 1][0];
        }
        for (int i = 1; i < row; i++)
        {
            for (int j = 1; j < column; j++)
            {
                grid[i][j] += Math.Min(grid[i - 1][j], grid[i][j - 1]);
            }
        }

        var ans = grid[row - 1][column - 1];

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                Console.Write(grid[i][j] + "  ");
            }
            Console.WriteLine();
        }

        return ans;
    }
}