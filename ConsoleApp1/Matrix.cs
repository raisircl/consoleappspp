using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Matrix
    {
        public int[,] a{ get; set; }
        public Matrix()
        {
            a= new int[3,3];    
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for(int i=0; i<3; i++)
            {
                for(int j=0; j<3; j++)
                {
                    sb.Append(a[i,j] + " ");
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }   
        public static Matrix operator+(Matrix m1, Matrix m2)
        {
            Matrix temp = new Matrix();
            for(int i=0; i<3; i++)
            {
                for(int j=0; j<3; j++)
                {
                    temp.a[i,j] = m1.a[i,j] + m2.a[i,j];
                }
            }
            return temp;
        }
         public static Matrix operator-(Matrix m1, Matrix m2)
        {
            Matrix temp = new Matrix();
            for(int i=0; i<3; i++)
            {
                for(int j=0; j<3; j++)
                {
                    temp.a[i,j] = m1.a[i,j] - m2.a[i,j];
                }
            }
            return temp;
        }   
    }
}
