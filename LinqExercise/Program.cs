using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.WebSockets;

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
            Console.WriteLine($"The Sum of numbers is {numbers.Where(x => x > 0).Sum()}");
            Console.WriteLine();

            //TODO: Print the Average of numbers
            Console.WriteLine($"The Average of numbers is {numbers.Where(x => x >= 0).Average()}");

            //ExtraCredit
            //Console.WriteLine();
            //Console.WriteLine("Extra Credit");
            //Console.WriteLine($"The Average number is {numbers.Average(numbers => numbers)}");

            //TODO: Order numbers in ascending order and print to the console
            var SortedNumbersInAsc = numbers.OrderBy(num => num);
            Console.WriteLine();
            Console.WriteLine("Order numbers in ascending order and print to the console");
            foreach (var number in SortedNumbersInAsc)
            {
                Console.WriteLine(number);
            }

            // Other way to do it
            Console.WriteLine();
            Console.WriteLine("Order numbers in ascending order using the collapsed expression");
            numbers.OrderBy(num => num).ToList().ForEach(num => Console.WriteLine(num));

            //TODO: Order numbers in descending order and print to the console
            var SortedNumbersInDes = numbers.OrderByDescending(num => num);
            Console.WriteLine();
            Console.WriteLine("Order numbers in descending order and print to the console");
            foreach (var number in SortedNumbersInDes)
            {
                Console.WriteLine(number);
            }
            //TODO: Print to the console only the numbers greater than 6
            Console.WriteLine();
            Console.WriteLine("Print to the console only the numbers greater than 6");
            var greaterNumbers = numbers.Where(num => num > 4);
            foreach (var number in greaterNumbers)
            {
                Console.WriteLine(number);
            }

            //TODO: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!**
            var SortedNumbersInAsc2 = numbers.OrderBy(num => num);
            Console.WriteLine();
            Console.WriteLine("Order numbers in ascending order");
            foreach (var number in SortedNumbersInAsc2)
            {
                Console.WriteLine(number);
            }

            int count = 0;
            Console.WriteLine();
            Console.WriteLine("only print 4 from the sorted list oop only usimg **foreach loop only**");
            foreach (var number in SortedNumbersInAsc2)
            {
                Console.WriteLine(number);
                count++;

                if (count == 4)
                    break;
            }

            //TODO: Change the value at index 4 to your age, then print the numbers in descending order
            int indexToChange = 4;
            int newValue = 25;
            numbers[indexToChange] = newValue;

            //numbers.SetValue(25, 4); - Other way

            var SortedNumbersInDes2 = numbers.OrderByDescending(num => num);
            Console.WriteLine();
            Console.WriteLine("Change the value at index 4 to your age, then print the numbers in descending order");
            foreach (var number in SortedNumbersInDes2)
            {
                Console.WriteLine(number);
            }



            // List of employees ****Do not remove this****
            var employees = CreateEmployees();
            //List<Employee> people = ListManager.LoadSimpleData();
            //foreach (var itemp in people)
            Console.WriteLine();
            Console.WriteLine("Print the list of the employees");
            foreach (Employee itemp in employees)
            {
                Console.WriteLine(itemp.FullName);
            }

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
            var firstNamewithC = employees.Where(x => x.FirstName[0] == 'C');
            Console.WriteLine();
            Console.WriteLine("Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName");
            Console.WriteLine();
            Console.WriteLine("Print all with FirstName starts with a C");
            foreach (var itemC in firstNamewithC)
            {
             Console.WriteLine(itemC.FirstName);

            }

            var firstNamewithS = employees.Where(x => x.FirstName[0] == 'S');
            Console.WriteLine();
            Console.WriteLine("Print all with FirstName starts with an S");
            foreach (var itemS in firstNamewithS)
            {
                Console.WriteLine(itemS.FirstName);

            }

            Console.WriteLine("Print all with FirstName starts with an S and C - Other approach");
            Console.WriteLine();
            employees.Where(x => x.FirstName.StartsWith("C") || x.FirstName.StartsWith("S")).OrderBy(x => x.FirstName).ToList().ForEach(x => Console.WriteLine(x.FullName));


            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            var AgeGreater26 = employees.Where(x => x.Age > 26).OrderBy(x => x.Age).ThenBy(n =>n.FirstName);
            Console.WriteLine();
            Console.WriteLine("Older than 26 and ordered by Age and then Firstname");
            foreach (var AgeMore26 in AgeGreater26)
            {
                 Console.WriteLine($"FullName is : {AgeMore26.FullName} and Age is : {AgeMore26.Age}");
            }

            //over 26 - Otherway of doing it
            Console.WriteLine();
            Console.WriteLine("Older than 26 and ordered by Age and then Firstname - Other way");
            var over26 = employees.Where(x => x.Age > 26).OrderBy(x => x.Age).ThenBy(x => x.FirstName);
            foreach (var person in over26)
            {
                Console.WriteLine($"Full Name: {person.FirstName}, Age: {person.Age}");
            }

           

            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            //Option 1
            //var YoeNAge = employees.Where(x => x.Age > 35);
            //var YoeNAge = employees.Where(x => x.Age > 35).ToList().ForEach(employees => employees.YearsOfExperience);
            ////numbers.OrderBy(num => num).ToList().ForEach(num => Console.WriteLine(num));
            //Console.WriteLine();
            //Console.WriteLine("Printing Option 1 to print Sum and Averge
            //Console.WriteLine("Sum");
            //int SumNAge = 0;
            //    foreach (var itemY in YoeNAge)
            //    { 
            //    Console.WriteLine($"{itemY.FullName}");
            //    SumNAge = itemY.Age++;
            //    Console.WriteLine(umNAgeSumN
            //    }

            //var YOE = employees.Where(x => x.YearsOfExperience < 10);
            ////OrderBy(x => x.Age).ThenBy(n => n.FirstName);
            //Console.WriteLine();
            //Console.WriteLine("Average");
            //foreach (var itemZ in YOE)
            //{
            //    Console.WriteLine($"{itemZ.FullName}"); // Does not work prints the names not the average
            //    Console.WriteLine();
            //   //NAge = itemZ.YearsOfExperience++;
            //}

            //Option 2
            var filter = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35);
            //IEnumerable<Employee> = filter = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35);
            var sum = filter.Sum(x => x.YearsOfExperience);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Printing Option 2 to print Sum and Averge");
            Console.WriteLine($"Sum of YOE: {sum}");
            double average = filter.Average(x => x.YearsOfExperience);
            Console.WriteLine($"Average of YOE: {average}");

            //TODO: Add an employee to the end of the list without using employees.Add()
            Employee newEmployee = new Employee("Myriam", "Pericles", 19, 1); // Custom Constructor
            Console.WriteLine();
            Console.WriteLine("List of Employees with the new employee appended");
            employees.Append(newEmployee).ToList().ForEach(x => Console.WriteLine(x.FullName));
            
            
            Console.WriteLine();
            Console.WriteLine("List of Employees without the new employee appended");
            foreach (var itemg in employees)
            {
                Console.WriteLine(itemg.FullName);
            }
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
    }
}
