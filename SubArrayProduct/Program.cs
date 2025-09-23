public class Program
{
    // link  https://leetcode.com/problems/subarray-product-less-than-k/submissions/1779909062/
    static void Main(string[] args)
    {
        var ans = NumSubarrayProductLessThanK(new int[] { 10, 9, 10, 4, 3, 8, 3, 3, 6, 2, 10, 10, 9, 3 }, 19);
        Console.WriteLine("ans: " + ans);
    }

    public static int NumSubarrayProductLessThanK(int[] nums, int k)
    {
        int count = 0, value = 0, start = 0, curr = 1, temp, ans = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            value = nums[i];
            count++;
            curr *= value;
            if (curr < k)
            {
                temp = (i - start + 1);
                ans += temp;
            }
            else
            {
                while (start <= i)
                {
                    if (curr < k) break;
                    curr /= nums[start];
                    start++;
                }

                temp = (i - start + 1);
                ans += temp;
            }
            //Console.WriteLine("Index: " + i + "  value: " + value + " curr: " + curr + " start: " + start + " count: " + count);
        }

        return ans;
    }
}