namespace Demo01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Struct
            ////Point
            //Point P01; //Declare for object from type 'Point'
            //P01.X = P01.Y = 12;

            //Console.WriteLine(P01.X); //12
            //Console.WriteLine(P01.Y); //12

            ////initialize with calling built-in or user-defined constructor
            //Point P02 = new Point(); //Point P02 = new Point();
            //Console.WriteLine(P02.X);
            //Console.WriteLine(P02.Y);

            ////initialize with calling built-in or user-defined constructor
            //Point P03 = new Point(1, 2); //Point P02 = new Point();
            //Console.WriteLine(P03.X); //1
            //Console.WriteLine(P03.Y); //2

            //Console.WriteLine(P03); //Demo01.Point

            //P03.PrintPoint(); //(1,2)
            //Console.WriteLine(P03.ToString()); //(1, 2) 

            #endregion

            #region Encapsulation Using Setter and Getter
            //Employee E01 = new Employee(1, "Hussein", -100);
            //E01.SetId(1);
            //E01.SetName("Hussein");
            //E01.SetSalary(-100);

            //Console.WriteLine(E01.GetId());
            //Console.WriteLine(E01.GetName());
            //Console.WriteLine(E01.GetSalary());

            //Employee E02 = new(2, "Mahmoud", 20000);
            //Console.WriteLine(E02.GetId());
            //Console.WriteLine(E02.GetName());
            //Console.WriteLine(E02.GetSalary());

            //Console.WriteLine(E02);

            #endregion

            #region Encapsulation Using Property [Full][Automatic]
            //Employee E03 = new();

            //E03.Id = 3;
            //E03.Name = "Fouad";
            //E03.Salary = 10000;
            //E03.Address = "Cairo";

            //Console.WriteLine(E03.Id); //3
            //Console.WriteLine(E03.Name); //Fouad
            //Console.WriteLine(E03.Salary); //10000
            //Console.WriteLine(E03.Address); //Cairo
            #endregion

            #region Encapsulation Using Property Indexer
            //PhoneBook phoneBook01 = new PhoneBook(3);

            //phoneBook01.AddPerson("Hussein", 123, 0);
            //phoneBook01.AddPerson("Mahmoud", 456, 1);
            //phoneBook01.AddPerson("Fouad", 789, 2);

            //Console.WriteLine(phoneBook01.GetNumber("Mahmoud")); //456

            //phoneBook01.UpdateNumber("Fouad", 10);
            //Console.WriteLine(phoneBook01.GetNumber("Fouad")); //10



            //phoneBook01["Hussein"] = 777;
            //Console.WriteLine(phoneBook01["Hussein"]); //777

            //phoneBook01[456] = "Mahmoud2";
            //Console.WriteLine(phoneBook01[456]); //Mahmoud2

            #endregion

            #region Class
            Car C01 = new Car(123, 320, "BMW");

            Console.WriteLine(C01.Id); //123
            Console.WriteLine(C01.Model); //BMW
            Console.WriteLine(C01.Speed); //320
            Console.WriteLine(C01); //Id: 123 ::: Speed: 320 ::: Model: BMW


            #endregion


        }
    }
}
