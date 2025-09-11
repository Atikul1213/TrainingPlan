public class Program
{
    // link https://www.hackerrank.com/contests/software-engineer-prep-kit/challenges/find-smallest-missing-positive-integer/submissions/code/1397265534

    public static void Main(string[] args)
    {
        int orderNumbersCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> orderNumbers = new List<int>();

        for (int i = 0; i < orderNumbersCount; i++)
        {
            int orderNumbersItem = Convert.ToInt32(Console.ReadLine().Trim());
            orderNumbers.Add(orderNumbersItem);
        }

        int result = findSmallestMissingPositive(orderNumbers);

        Console.WriteLine(result);
    }

    public static int findSmallestMissingPositive(List<int> orderNumbers)
    {
        var Input = new SortedSet<int>();
        foreach (var num in orderNumbers)
            Input.Add(num);
        int miss = 1;
        foreach (var num in Input)
        {
            if (num > 0)
            {
                if (num == miss)
                {
                    miss++;
                }
                else break;
            }
        }

        return miss;

    }
}