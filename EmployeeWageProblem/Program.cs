using System;
namespace EmployeeWageProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Computation Problem");

            CheckEmployee checkEmployee = new CheckEmployee();
            checkEmployee.CheckAttendence();
        }
    }
}
