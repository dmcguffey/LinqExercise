using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Schema;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers
            Console.WriteLine("------Sum-------");
            blank();
            Console.WriteLine(numbers.Sum(x => x));
            blank();

            //TODO: Print the Average of numbers
            Console.WriteLine("------Average______");
            blank();
            Console.WriteLine(numbers.Average(x => x));
            blank();

            //TODO: Order numbers in ascending order and print to the console
            Console.WriteLine("------Ordered by ascending order------");
            blank();
            var orderedNumbers = numbers.OrderBy(x => x);
            foreach (var number in orderedNumbers)
            {
                Console.WriteLine(number);
            }
            blank();

            //TODO: Order numbers in decsending order and print to the console
            Console.WriteLine("------Ordered by descending order-------");
            blank();
            var reversedNumbers = numbers.OrderByDescending(x => x);
            foreach (var number in reversedNumbers)
            {
                Console.WriteLine(number);
            }
            blank();


            //TODO: Print to the console only the numbers greater than 6
            Console.WriteLine("------Only numbers greater than 6------");
            blank();
            var numbersGreaterThanSix = numbers.Where(x => x > 6);
            foreach (var number in numbersGreaterThanSix)
            {
                Console.WriteLine(number);
            }
            blank();


            //TODO: Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**
            Console.WriteLine("------Order only 4 numbers------");
            blank();
            foreach (var number in numbers.OrderBy(x => x).Take(4))
            {
                Console.WriteLine(number);
            }
            blank();

            //TODO: Change the value at index 4 to your age, then print the numbers in decsending order
            Console.WriteLine("------Add my age to index 4------");
            blank();
            numbers.SetValue(29, 4);
            foreach (var number in numbers.OrderByDescending(x => x))
            {
                Console.WriteLine($"{number}");
            }
            blank();
            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
            Console.WriteLine("------Sort employees that start with C or S in the First Name------");
            blank();
            foreach (var employee in employees.Where(x => x.FirstName[0] == 'C' || x.FirstName[0] == 'S').OrderBy(x =>x.FirstName))
            {
                Console.WriteLine(employee.FullName);
            }
            blank();


            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            Console.WriteLine("------Print the full name of employees over the age of 26, sorted first by age, then by first name------");
            blank();
            foreach (var older in employees.Where(x => x.Age > 26).OrderBy(x => x.Age).OrderBy(x => x.FirstName))
            {
                Console.WriteLine($"{older.FullName}, age { older.Age}");
            }
            blank();

            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            Console.WriteLine("------Old but New Employees' Total experience and Average------");
            blank();
            var employeesOldButNew = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35);
            foreach(var employee in employeesOldButNew)
            {
                Console.WriteLine($"{employee.FullName},Age: {employee.Age}, Years of experience: {employee.YearsOfExperience}");
            }
            blank();
            Console.WriteLine($"Total experience for these employees: {employeesOldButNew.Sum(x => x.YearsOfExperience)}");
            blank();
            Console.WriteLine($"Average experience for these employees: {employeesOldButNew.Average(x => x.YearsOfExperience)}");
            blank();


            //TODO: Add an employee to the end of the list without using employees.Add()
            Console.WriteLine("------New Hire------");
            blank();
            Employee temp = new Employee() { FirstName = "Tanjiro", LastName = "Kamado", Age = 15, YearsOfExperience = 3};

           employees.Append(temp).ToList().ForEach(x => Console.WriteLine(x.FullName));


            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion

        public static void blank()
        { 
            Console.WriteLine();
        }
    }
}
