public class Program
{
    // link  https://www.hackerrank.com/challenges/diagonal-difference/submissions/code/447087732
    public static void Main(string[] args)
    {
        List<List<int>> arr = new List<List<int>>();

        int len = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < len; i++)
        {
            var input = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
            arr.Add(input.ToList());
        }

        int sum1 = 0, sum2 = 0;
        for (int i = 0; i < len; i++)
        {
            sum1 += arr[i][i];
            sum2 += arr[i][len - i - 1];
        }

        Console.WriteLine(Math.Abs(sum1 - sum2));
    }
}