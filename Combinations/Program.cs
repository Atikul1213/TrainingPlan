public class Program
{
    // link   https://leetcode.com/problems/combinations/submissions/1773592423
    public static void Main(string[] args)
    {
        List<List<int>> arr = new List<List<int>>();

        int len = Convert.ToInt32(Console.ReadLine());
        var input = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
    }

    public static IList<IList<int>> Combine(int n, int k)
    {
        var ans = new List<IList<int>>();
        Int64 one = Convert.ToInt64(1);
        Int64 mask = (one << n), count = 0, value = 0;

        for (Int64 i = 0; i < mask; i++)
        {
            count = 0;
            var temp = new List<int>();

            for (int j = 0; j < n; j++)
            {
                if (count > k) continue;

                value = (one << j);

                bool check = (i & value) > 0;

                if (check)
                {
                    count++;
                    temp.Add(j + 1);
                }
            }
            if (count == k)
                ans.Add(temp);
        }

        return ans;
    }

}