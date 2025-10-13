public class Program
{
    // Link: https://leetcode.com/problems/consecutive-numbers/submissions/1800147435
    public static void Main(string[] args)
    {
        /*
        # Write your MySQL query statement below
            select distinct(l1.num) as ConsecutiveNums 
            from Logs as l1, Logs as l2, Logs as l3
            where l2.id = l1.id-1 AND l3.id = l2.id-1
                AND l1.num = l2.num AND l2.num = l3.num;
         */
        Console.WriteLine("Hello, World!");
    }
}