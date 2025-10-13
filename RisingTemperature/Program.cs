public class Program
{
    // link https://leetcode.com/problems/rising-temperature/submissions/1800137228
    public static void Main(string[] args)
    {
        /*
        # Write your MySQL query statement below
            select w1.id
            from Weather as w1 , Weather as w2
            where w1.temperature > w2.temperature &&
                DateDiff(w1.recordDate, w2.recordDate)=1;
         */
        Console.WriteLine("Hello, World!");
    }
}