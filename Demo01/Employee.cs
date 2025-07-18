using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
    internal class Employee
    {
        private int id;
        private string name;
        private double salary;

        //Apply Encapsulation using Setter and Getter Method
        //Setter
        public void SetId(int id)
        {
            this.id = id;
        }

        //Getter
        public int GetId()
        { 
            return this.id;
        }

        public void SetName(string name)
        {
            if (name.Length >= 2 && name.Length <=20)
                this.name = name;
        }

        public string GetName()
        {
            return this.name;
        }

        public void SetSalary(double salary)
        {
            if (salary > 0) 
                this.salary = salary;
        }

        public double GetSalary()
        {
            return this.salary;
        }

        //Apply Encapsulation using full property
        public int Id
        {
            set
            {
                id = value;
            }

            get
            {
                return id;
            }
        }

        public string Name
        {
            set
            {
                if (value.Length >= 2 && value.Length <= 20 )
                {
                    name = value;
                }
                
            }

            get
            {
                return name;
            }
        }

        public double Salary
        {
            set
            {
                if (value > 0)
                {
                    salary = value;
                }
                
            }

            get
            {
                return salary;
            }
        }

        //Apply Encapsulation using automatic property
        public string Address { set; get; }
        

        //Constructor
        public Employee(int id, string name, double salary)
        {
            SetId(id);
            SetName(name);
            SetSalary(salary);
        }

        public Employee()
        {
            id = default;
            name = default;
            salary = default;
            Address = default;
        }

        //override ToString() built-in function
        public override string ToString()
        {
            return $"Id: {id} :: Name {name} :: Salary {salary}";
        }


         



    }
}
