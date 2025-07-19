using System.Drawing;

namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01
            #region Q01
            /* 1.Create a struct called "Point" to represent a 2D point with properties "X" and "Y".
                                * Write a C# program that takes two points as input from the user and calculates the distance between them. */
            //Point P01 = new Point();
            //Point P02 = new Point();

            //Console.WriteLine("Enter the coordinate X of the first point P01");
            //P01.X = double.Parse(Console.ReadLine());


            //P01.Y = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the coordinates of the second point P02");
            //P02.X = double.Parse(Console.ReadLine()); 
            //P02.Y = double.Parse(Console.ReadLine());

            //Console.WriteLine($"the disance between P01 and P02 is {Math.Sqrt(Math.Pow(P02.X - P01.X, 2) + Math.Pow(P02.Y - P01.Y, 2))}");
            #endregion

            #region Q02
            /* 2.Create a struct called "Person" with properties "Name" and "Age".
             * Write a C# program that takes details of 3 persons as input from the user and displays
             * the name and age of the oldest person. */

            //Person[] P_arr = new Person[3];
            //int indexOfOldestPerson=0;
            //int highestAge;

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.Write($"Enter the name of the {i+1}th person: ");
            //    P_arr[i].Name = Console.ReadLine();

            //    Console.Write($"Enter the age of the {i + 1}th person: ");
            //    P_arr[i].Age = int.Parse(Console.ReadLine());
            //}

            //highestAge = P_arr[0].Age;

            //for (int i = 1; i < 3; i++)
            //{
            //    if (P_arr[i].Age > highestAge)
            //    {
            //        indexOfOldestPerson = i;
            //    }
            //}

            //Console.WriteLine($"Name of the oldest person is {P_arr[indexOfOldestPerson].Name}");
            //Console.WriteLine($"Age of the oldest person is {P_arr[indexOfOldestPerson].Age}");
            #endregion

            #endregion

            #region Par02

            /*1. Design and implement a Class for the employees in a company:
                 * Notes:
                 * ● Employee is identified by an ID, Name, security level, salary, hire date and Gender.
                 * ● We need to restrict the Gender field to be only M or F [Male or Female]
                 * ● Assign the following security privileges to the employee (guest, Developer, secretary and DBA) in a form of Enum.
                 * ● We want to provide the Employee Class to represent Employee data in a string Form (override ToString ()), 
                 * display employee salary in a currency format. [Use String.Format() Function].
                 * --------------------------------------------------------------------------------------------------------------------
                 * Develop a Class to represent the Hiring Date Data:
                 * ● Consisting of fields to hold the day, month and Years.
                 * --------------------------------------------------------------------------------------------------------------------
                 * Create an array of Employees with size three a DBA, Guest and the third one is security officer
                 * who have full permissions. (Employee [] EmpArr;)
                 * Notes:
                 * ● Implement All the Necessary Member Functions on the Class (Getters, Setters)
                 * ● Define all the Necessary Constructors for the Class
                 * ● Allow NO RUNTIME errors if the user inputs any data
                 * ● Write down all the necessary Properties (Instead of setters and getters)
                 */

            Employee[] EmpArr = new Employee[3];
            Employee_HiringDate[] employee_HiringDateArr = new Employee_HiringDate[3];


            for (int i = 0; i < 3; i++)
            {
                EmpArr[i] = new Employee();
                employee_HiringDateArr[i] = new Employee_HiringDate();
                int temp_int;
                Gender temp_gender;
                double temp_double;


                //Entering the employee id
                do
                {
                    Console.Write($"Enter the Id of employee number {i + 1}: ");
                    
                }
                while (!int.TryParse(Console.ReadLine(), out temp_int));
                EmpArr[i].Id = temp_int;


                //Entering the employee name
                Console.Write($"Enter the Name of employee number {i + 1}: ");
                EmpArr[i].Name = Console.ReadLine() ?? "No Name";


                //Entering the employee gender
                do
                {
                    Console.Write($"Enter the gender of employee number {i + 1} M or F: ");

                }
                while (!Enum.TryParse(Console.ReadLine(), out temp_gender));
                EmpArr[i].Gender = temp_gender;
             

                //Entering the employee salary
                do
                {
                    Console.Write($"Enter the Salary of employee number {i + 1}: ");
                }
                while (!double.TryParse(Console.ReadLine(), out temp_double));
                EmpArr[i].Salary = temp_double;



                //Entering the hiring date
                //day
                do
                {
                    Console.Write($"Enter the Hiring date day of employee number {i + 1}: ");
                }
                while (!int.TryParse(Console.ReadLine(), out temp_int));
                employee_HiringDateArr[i].Day = temp_int;

                //month
                do
                {
                    Console.Write($"Enter the Hiring date month of employee number {i + 1}: ");
                }
                while (!int.TryParse(Console.ReadLine(), out temp_int));
                employee_HiringDateArr[i].Month = temp_int;


                //Year
                do
                {
                    Console.Write($"Enter the Hiring date day of employee number {i + 1}: ");
                }
                while (!int.TryParse(Console.ReadLine(), out temp_int));
                employee_HiringDateArr[i].Year = temp_int;

                EmpArr[i].Date = employee_HiringDateArr[i];


                Console.WriteLine("===================================================================");
            }

            EmpArr[0].SecurityLevel = Security_Level.DBA;
            EmpArr[1].SecurityLevel = Security_Level.Guest;
            EmpArr[2].SetFullPermissions();




            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(EmpArr[i].ToString());
                Console.WriteLine("===================================================================");
            }





            #endregion
        }
    }
}
