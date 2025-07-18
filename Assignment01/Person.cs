using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    internal struct Person
    {
        private string name;
        private int age;


        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value > 0)
                    age = value;

                else
                    age = 0;
            }
        }
        
    }
}
