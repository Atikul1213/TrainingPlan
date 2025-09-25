public class Program
{
    public static void Main(string[] args)
    {
        FindArray(new int[] { 5, 2, 0, 3, 1 });
        Console.WriteLine("Hello word");
    }



    public static int[] FindArray(int[] pref)
    {
        var ans = new int[pref.Length];
        ans[0] = pref[0];

        for (int i = 1; i < pref.Length; i++)
        {
            ans[i] = pref[i - 1] ^ pref[i];
        }

        for (int i = 0; i < pref.Length; i++)
        {
            Console.WriteLine("i: " + i + "  value: " + ans[i]);
        }
        return ans;
    }


}