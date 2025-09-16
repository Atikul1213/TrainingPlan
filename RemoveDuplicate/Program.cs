public class Program
{
    // link https://leetcode.com/problems/remove-duplicates-from-sorted-array/submissions/1772656367
    public static void Main()
    {
        List<List<int>> arr = new List<List<int>>();

        int len = Convert.ToInt32(Console.ReadLine());
        var nums = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);

        var hset = new HashSet<int>();
        int uniqueCount = 0;

        foreach (var num in nums)
        {
            if (!hset.Contains(num))
            {
                hset.Add(num);
            }
        }
        int idx = 0;
        foreach (var item in hset)
        {
            nums[idx++] = item;
        }

        foreach (var item in hset)
        {
            Console.WriteLine("item: " + item);
        }

        Console.WriteLine("Length: " + hset.Count());
    }
}