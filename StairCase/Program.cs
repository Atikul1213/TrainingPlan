public class Program
{
    // link   https://www.hackerrank.com/challenges/plus-minus/submissions/code/447088766
    public static void Main(string[] args)
    {
        List<List<int>> arr = new List<List<int>>();

        int len = Convert.ToInt32(Console.ReadLine());
        var input = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);

        int pos = 0, neg = 0, zero = 0;
        for (int i = 0; i < len; i++)
        {
            if (input[i] > 0) pos++;
            else if (input[i] < 0) neg++;
            else
                zero++;
        }
        double posValue = (double)pos / (double)len;

        double negValue = (double)neg / (double)len;

        double zeroValue = (double)zero / (double)len;

        Console.WriteLine(posValue.ToString("0.000000"));
        Console.WriteLine(negValue.ToString("0.000000"));
        Console.WriteLine(zeroValue.ToString("0.000000"));
    }
}