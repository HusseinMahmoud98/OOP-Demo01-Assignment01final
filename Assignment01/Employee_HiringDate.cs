using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    internal class Employee_HiringDate
    {
        private int day;
        private int month;
        private int year;

        public Employee_HiringDate()
        {
            day = 1;
            month = 1;
            year = 2025;
        }

        public int Day
        {
            set
            {
                if (value >= 1 && value <= 31)
                {
                    day = value;
                }
            } 

            get 
            { 
                return day; 
            }
        }

        public int Month
        {
            set 
            {
                if (value>=0 && value <=12)
                {
                    month = value;
                }

            }
            get 
            { 
                return month;
            }
        }

        public int Year
        {  
            set {
                if (value>= 0 )
                {
                    year = value;
                }

            }
            get
            {
                return year;
            }
        } 
    }
}
