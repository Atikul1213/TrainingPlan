public class Program
{
    // link  https://www.hackerrank.com/challenges/compare-the-triplets/submissions/code/447086529
    public static void Main(string[] args)
    {
        var Input1 = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
        var Input2 = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);

        int length = Input1.Length, cnt1 = 0, cnt2 = 0;
        for (int i = 0; i < length; i++)
        {
            if (Input1[i] > Input2[i]) cnt1++;
            if (Input1[i] < Input2[i]) cnt2++;
        }
        Console.WriteLine(cnt1 + " " + cnt2);
    }
}