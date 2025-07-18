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

            Person[] P_arr = new Person[3];
            int indexOfOldestPerson=0;
            int highestAge;

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Enter the name of the {i+1}th person: ");
                P_arr[i].Name = Console.ReadLine();

                Console.Write($"Enter the age of the {i + 1}th person: ");
                P_arr[i].Age = int.Parse(Console.ReadLine());
            }

            highestAge = P_arr[0].Age;

            for (int i = 1; i < 3; i++)
            {
                if (P_arr[i].Age > highestAge)
                {
                    indexOfOldestPerson = i;
                }
            }

            Console.WriteLine($"Name of the oldest person is {P_arr[indexOfOldestPerson].Name}");
            Console.WriteLine($"Age of the oldest person is {P_arr[indexOfOldestPerson].Age}");



            #endregion

            #endregion
        }
    }
}
