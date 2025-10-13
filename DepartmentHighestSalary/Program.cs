public class Program
{
    // Link: https://leetcode.com/problems/department-highest-salary/submissions/1800177320
    public static void Main(string[] args)
    {
        /*
        # Write your MySQL query statement below
        select d.name as Department, e.name as Employee, e.salary as Salary
        from Employee  as e
        join Department as d
        on e.departmentId = d.id
        where e.salary = (select max(salary)
                    from Employee
                    where departmentId = e.departmentId
                );
 
         */
        Console.WriteLine("Hello, World!");
    }
}