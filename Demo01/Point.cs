using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
    internal struct Point
    {
        public int X;
        public int Y;

        // Constructor : Special Methods
        //               1. Named Like Stuct
        //               2. Has no return type

        public Point()
        {
            X = 3;
            Y = 5;
        }

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void PrintPoint()
        {
            Console.WriteLine($"({X},{Y})");
        }

        public override string ToString()
        {
            //return base.ToString();
            return $"({X}, {Y})";
        }
    }
}
