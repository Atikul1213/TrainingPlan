public class Program
{
    public static void Main(string[] args)
    {

    }

    public static long aVeryBigSum(List<long> ar)
    {
        long sum = 0;
        foreach (var item in ar)
            sum += item;

        return sum;
    }
}