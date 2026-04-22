using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
   
    public class Rect
    {
        // Constructor : It is a special method which is used to initialize the object of a class.
        // It has the same name as the class and it does not have any return type.
        // it always be public and it is automatically called when we create an object of the class.
        // it always called once for each object of the class.
        public Rect()
        {
            Length = 1;
            Breadth = 1;
        }
        // parameterized constructor : It is a constructor which takes parameters to initialize the object of a class.
        public Rect(int l, int b)
        {
            Length = l;
            Breadth = b;
        }
        // copy constructor : It is a constructor which takes an object of the same class as a parameter to initialize the object of a class.
        public Rect(Rect r)
        {
            this.Length = r.Length;
            this.Breadth = r.Breadth;
        }
        // this is reference variable which is used to refer the current object of the class.

        public int Length { get; set; }
        public int Breadth { get; set; }

        public int Area()
        {
            return Length * Breadth;
        }   
        public int Perimeter()
        {
                return 2 * (Length + Breadth);
        }
    }
}
/*
Oops : Object Oriented Programming System

As we know our real life is full of objects like pen, pencil, book, chair, table, car, bike etc. 
and these objects have some properties and behaviors. 
For example a pen has properties like color, brand, price etc. and 
It has behaviors like writing, drawing etc. 
Similarly a car has properties like color, brand, price etc. and it has behaviors like running, stopping etc. 
So in oops we can create our own data type which is called class and we can create objects of that class and 
we can access the properties and behaviors of that class through the objects. 
In c# we use class keyword to create a class and we use new keyword to create an object of that class. 
The syntax for creating a class is as follows:
Oops Paradigm : Encapsulation, Inheritance, Polymorphism, Abstraction
Encapsulation : 
        It is the process of wrapping data and code together as a single unit.
        That single unit is called class.During Encapsulation, the variables of a class will be hidden 
        from other classes and can be accessed only through the methods of their current class.
        1. Propeties: Decide how an object look like
        2. Behaviors: Decide how an object behave like
        3. Events: Decide how an object react to some action    
 Data Hiding : It is the process of hiding the internal details of an object from the outside world.
        To achive data hiding we use access specifiers like private, protected, internal, public etc.

Inheritance : It is the process of deriving a new class from an existing class.
*/
