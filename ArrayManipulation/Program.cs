public class Program
{
    // link https://www.hackerrank.com/challenges/sparse-arrays/submissions/code/446950871
    public static void Main(string[] args)
    {
        var n = Convert.ToInt32(Console.ReadLine().Trim());
        var dict = new Dictionary<string, int>();

        for (int i = 0; i < n; i++)
        {
            var value = Console.ReadLine();
            if (dict.ContainsKey(value))
            {
                dict[value]++;
            }
            else
            {
                dict[value] = 1;
            }
        }

        var query = Convert.ToInt32(Console.ReadLine());

        while (query > 0)
        {
            var key = Console.ReadLine();
            if (dict.ContainsKey(key))
                Console.WriteLine(dict[key]);
            else
                Console.WriteLine(0);
            query--;
        }
    }
}