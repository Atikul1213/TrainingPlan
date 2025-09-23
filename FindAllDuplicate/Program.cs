public class Program
{
    // link https://leetcode.com/problems/find-all-duplicates-in-an-array/submissions/1779882696/
    static void Main(string[] args)
    {

    }

    public static IList<int> FindDuplicates(int[] nums)
    {
        int[] tempArray = new int[100005];
        var ans = new HashSet<int>();

        for (int i = 0; i < 100005; i++)
            tempArray[i] = -1;

        for (int i = 0; i < nums.Length; i++)
        {
            var value = nums[i];
            if (tempArray[value] == -1)
                tempArray[value] = value;
            else
            {
                tempArray[value] = tempArray[value] ^ value;
            }
        }

        for (int i = 0; i < nums.Length; i++)
        {
            var value = nums[i];
            if (tempArray[value] == 0)
                ans.Add(value);
        }

        return ans.ToList();
    }

}