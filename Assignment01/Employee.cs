using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{

    enum Gender
    {
        M,
        F
    }


    [Flags]
    enum Security_Level
    {
        Guest = 1,
        Developer = 2,
        Secretary = 4,
        DBA = 8
    }



    internal class Employee
    {

        /***************************** PRIVATE ATTRIBUTES *********************************************/
        private int id;
        private string name;
        private double salary;
        private Security_Level security_Level;
        private Gender gender;
        private Employee_HiringDate date;

        /******************************** CONSTRUCTORS ************************************************/
        public Employee(int id, string name, double salary)
        {
            //use full prpperty in setter and getter
            Id = id;
            Name = name ?? "No name";
            Salary = salary;
            date = new Employee_HiringDate();
        }

        public Employee()
        {
            id = default;
            name = default;
            salary = default;
            gender = Gender.M;
            security_Level = Security_Level.Guest;
        }


        /************************************* FULL PROPERTIES ****************************************/
        public int Id
        {
            set
            {
                if (value > 0)
                {
                    id = value;
                }
            }

            get 
            {
                return id;
            }
        }

        public string Name
        {
            set { name = value?? ""; }
            get { return name; }
        }

        public double Salary
        {
            set { salary = value; }
            get { return salary; }
        }

        

        public Security_Level SecurityLevel
        {
            set
            {
                if (Enum.IsDefined(typeof(Security_Level), value))
                {
                    security_Level = value;
                }
                
            }

            get
            {
                return security_Level;
            }
        }

        public Gender Gender
        {
            set
            {
                if (Enum.IsDefined(typeof(Gender), value))
                {
                    gender = value;
                }
            }

            get
            {
                return gender;
            }
        }




        public Employee_HiringDate Date
        {
            set
            {
                date = value;
            }

            get
            {
                return date;
            }
        }


        /************************************* PUBLIC METHODS ****************************************/
        public void AddSecurityLevel(Security_Level security_level)
        {
            if (Enum.IsDefined(typeof(Security_Level), security_level))
            {
                this.security_Level |= security_level;
            }
        }

        public void SetFullPermissions()
        {
           security_Level = Security_Level.DBA | Security_Level.Developer | Security_Level.Guest | Security_Level.Secretary;          
        }



        public override string ToString()
        {
            return $"Id:{id}\nName: {name}\nSalary: {string.Format("{0:C}", salary)}\n Security Level: {security_Level}\nHiring Date: {Date.Day}/{Date.Month}/{Date.Year}";
        }


    }
}
