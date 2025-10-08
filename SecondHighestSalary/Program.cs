
//link  https://leetcode.com/problems/second-highest-salary/submissions/1795118857

/*
# Write your MySQL query statement below
select max(salary) as SecondHighestSalary
from Employee
where salary<>(select max(salary)
    from Employee
);
*/
Console.WriteLine("Hello, World!");
