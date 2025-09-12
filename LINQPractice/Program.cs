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

        var filterResult = slist.Where((s, i) =>
        {
            if (i % 2 == 0)
                return true;  // if it is even element
            return false;
        });



        //Sorting

        var orderByResult = from s in slist
                            orderby s.Age
                            select s;
        var orderByResultDesc = from s in slist
                                orderby s.Age descending
                                select s;

        var orderByResult1 = slist.OrderBy(s => s.Age);

        var orderByResultDesc1 = slist.OrderByDescending(s => s.Age);


        // thenBy

        var orderThanBy = from s in slist
                          orderby s.Age ascending, s.StudentId descending
                          select s;
        var orderThanBy1 = slist.OrderBy(s => s.Age).ThenByDescending(s => s.StudentId);


        // Grouping
        var groupByResult = slist.GroupBy(s => s.Age);
        var groupByResult1 = from s in slist
                             group s by s.Age;

        // All Any Contains
        bool isExistTeenAger = slist.All(s => s.Age > 12 && s.Age < 20);
        bool isAnyStuddentTeenAger = slist.Any(s => s.Age > 12 && s.Age < 20);

        /// Aggregate
        var allStudentName = slist.Aggregate<Student, string>("Student Name: ",
            (str, s) => str += s.StudentName + ",");

        var avgAge = slist.Average(s => s.Age);
        var adultStudet = slist.Count(s => s.Age > 18);

        var oldest = slist.Max(s => s.Age);
        var sumOfAge = slist.Sum(s => s.Age);

        IList<int> intList = new List<int>() { 10, 21, 30, 45, 50, 87 };

        IList<string> strList =
        new List<string>() { null, "Two", "Three", "Four", "Five" };


        var res1 = intList.FirstOrDefault(x => x > 10);
        var res2 = intList.LastOrDefault(x => x > 10);

        IList<Standard> stnList = new List<Standard>()
        {
            new Standard() { StandardId =1, StandardName="Standard 1"},
            new Standard() { StandardId =2, StandardName="Standard 2"},
            new Standard() { StandardId =3, StandardName="Standard 3"},
            new Standard() { StandardId =4, StandardName="Standard 4"},
            new Standard() { StandardId =5, StandardName="Standard 5"},
        };

        var innerJoin = slist.Join(
            stnList,
            student => student.StandardId,
            standard => standard.StandardId,
            (student, standard) => new
            {
                StudentName = student.StudentName,
                StandardName = standard.StandardName
            });

        var innerJoin1 = from s in slist
                         join st in stnList
                         on s.StandardId equals st.StandardId
                         select new
                         {
                             StudentName = s.StudentName,
                             StandardName = st.StandardName
                         };

    }

}