using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Shape
    {
        //Function Overloading - It has same name but different parameters
        public void Area(int a, int b)
        {
            Console.WriteLine($"Area of rectangle is {a * b}");
        }
        public void Area(int a)
        {
            Console.WriteLine($"Area of square is {a * a}");
        }
        public void Area(double r)
        {
            double a =Math.Round(Math.PI * r * r,2);
            Console.WriteLine($"Area of circle is {a}");
        }
    }
}
