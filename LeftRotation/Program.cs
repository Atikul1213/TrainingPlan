public class Program
{
    // link https://www.hackerrank.com/challenges/array-left-rotation/submissions/code/446949266
    public static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');

        var n = Convert.ToInt32(input[0]);
        var d = Convert.ToInt32(input[1]);

        var array = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);

        for (int i = d + 1; i <= n; i++)
            Console.Write(array[i - 1] + " ");

        for (int i = 0; i < d; i++)
            Console.Write(array[i] + " ");
        Console.WriteLine();
    }
}