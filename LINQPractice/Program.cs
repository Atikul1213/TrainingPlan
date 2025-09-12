using LINQPractice;

public class Program
{
    public static void Main(string[] args)
    {
        string[] word = { "hello", "wonderful", "LINQ", "beautiful", "world" };

        var longWords = word.Where(w => w.Length > 5).Count();
        Console.WriteLine("Long world: " + longWords);


        var containLetter = from w in word
                            where w.Contains("word", StringComparison.InvariantCultureIgnoreCase)
                            select w;

        var containLetter1 = word.Where(w => w.Contains("word", StringComparison.InvariantCultureIgnoreCase));

        Console.WriteLine("contain Letter count: " + containLetter.Count());


        IList<Student> slist = new List<Student>()
        {
            new Student() { StudentId = 1, StudentName = "John", Age = 13 } ,
            new Student() { StudentId = 2, StudentName = "Moin",  Age = 21 } ,
            new Student() { StudentId = 3, StudentName = "Bill",  Age = 18 } ,
            new Student() { StudentId = 4, StudentName = "Ram" , Age = 20 } ,
            new Student() { StudentId = 5, StudentName = "Ron" , Age = 15 }
        };


        var teenAgerStudent = from s in slist
                              where s.Age > 12 && s.Age < 20
                              select s;

        var teenAgerStudent1 = slist.Where(s => s.Age > 12 && s.Age < 20);
        Console.WriteLine("Teen age student count: " + teenAgerStudent.Count());


    }
}