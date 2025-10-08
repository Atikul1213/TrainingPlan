public class Program
{
    // link  https://leetcode.com/problems/single-number/submissions/1795092731
    public static void Main(string[] args)
    {

        Console.WriteLine("Hello word");
    }

    public static int SingleNumber(int[] nums)
    {
        int ans = 0;
        foreach (var num in nums)
        {
            ans = ans ^ num;
        }


        return ans;
    }
}