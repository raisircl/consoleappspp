using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    //Inheritance - It is a process of creating new class from existing class.
    //The new class is called derived class and the existing class is called base class.
    //The derived class inherits the properties and methods of the base class.
    internal class Box : Rect
    {
        public int Height { get; set; }
         public Box()
        {
            Height = 0;
        }
        public Box(int length, int breadth, int height) : base(length, breadth)
        {
            Height = height;
        }
         public Box(Box b) : base(b.Length, b.Breadth)
        {
            this.Height = b.Height;
        }
         public int Volume()
        {
           return Length * Breadth * Height;
        }
    }
}
