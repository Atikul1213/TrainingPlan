public class Program
{
    //link https://leetcode.com/problems/rank-scores/submissions/1800050195
    public static void Main(string[] args)
    {
        /*  
         Select s1.score, count(s2.score) as 'rank'
        From Scores as s1,
        (select distinct score from Scores) s2
        where s1.score <= s2.score
        group by s1.id
        order by s1.score desc;
         */
        Console.WriteLine("Hello word");
    }
}