public class Program
{
    // link   https://leetcode.com/problems/container-with-most-water/submissions/1772687698
    public static void Main(string[] args)
    {
        List<List<int>> arr = new List<List<int>>();

        // int len = Convert.ToInt32(Console.ReadLine());
        var height = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);

        int st = 0, ed = height.Length - 1, max = 0, value = 0;
        while (st < ed)
        {
            value = Math.Min(height[st], height[ed]) * (ed - st);
            max = Math.Max(max, value);

            if (height[st] <= height[ed])
            {
                st++;
            }
            else ed--;
        }

        Console.WriteLine("Max: " + max);

    }
}