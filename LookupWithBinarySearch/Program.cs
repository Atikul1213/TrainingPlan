public class Program
{

    // link https://www.hackerrank.com/contests/software-engineer-prep-kit/challenges/lookup-with-binary-search/submissions/code/1397264216
    public static void Main(string[] args)
    {
        int numsCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> nums = new List<int>();

        for (int i = 0; i < numsCount; i++)
        {
            int numsItem = Convert.ToInt32(Console.ReadLine().Trim());
            nums.Add(numsItem);
        }

        int target = Convert.ToInt32(Console.ReadLine().Trim());

        int result = binarySearch(nums, target);

        Console.WriteLine(result);
    }

    public static int binarySearch(List<int> nums, int target)
    {
        int st = 0, ed = nums.Count() - 1, mid, pos = -1;

        while (st <= ed)
        {
            mid = (st + ed) / 2;
            if (nums[mid] == target)
            {
                pos = mid;
                break;
            }
            else if (nums[mid] < target)
            {
                st = mid + 1;
            }
            else
            {
                ed = mid - 1;
            }
        }
        return pos;
    }
}