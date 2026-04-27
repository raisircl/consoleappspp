using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Distance
    {
        public int Feet { get; set; }
        public int Inch { get; set; }

        public Distance()
        {
            Feet = 0;   
            Inch = 0;   
        }
        public Distance(int feet, int inch  )
        {
            Feet = feet;    
            Inch = inch;
        }
        public Distance(Distance d)
        {
            this.Feet = d.Feet;
            this.Inch = d.Inch;
        }
        public override string ToString()
        {
            if(Inch >= 12)
            {
                Feet += Inch / 12;
                Inch = Inch % 12;
            }
            return $" {Feet}\"{Inch}'";
        }
        public static Distance  operator+(Distance d1, Distance d2)
        {
            Distance temp = new Distance();
            temp.Feet = d1.Feet + d2.Feet;
            temp.Inch = d1.Inch + d2.Inch;
            return temp;
        }
        public static bool operator ==(Distance d1, Distance d2)
        {
            return (d1.Feet == d2.Feet) && (d1.Inch == d2.Inch);
        }
        public static bool operator !=(Distance d1, Distance d2)
        {
            return !(d1 == d2);
        }
    }
}
