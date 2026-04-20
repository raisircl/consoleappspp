//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace ConsoleApp1
//{
//    internal class Matrix
//    {
//        static void Main(string[] args)
//        {
//            //Matrix - Two Dimensional Array - Store data in rows and columns
//            //syntax : dataType[,] matrixName = new dataType[rows, columns];
//            // in c lang we use int matrix[3][3] but in c# we use int[,] matrix = new int[3,3]
//            int[,] a = new int[3, 3];
//            int i, j;
//            /*a[0,0] = 1;
//            a[0,1] = 2;
//            a[0,2] = 3;
//            // row 2nd 
//            a[1,0] = 4; 
//            a[1,1] = 5;
//            a[1,2] = 6;
//            // row 3rd
//            a[2,0] = 7;
//            a[2,1] = 8;
//            a[2,2] = 9;*/
//            for (i = 0; i < 3; i++)
//            {
//                for (j = 0; j < 3; j++)
//                {
//                    Console.Write($"Enter element at position [{i},{j}] : ");
//                    a[i, j] = Convert.ToInt32(Console.ReadLine());
//                }
//            }

//            /*Console.Write($"{a[0, 0]}\t");
//            Console.Write($"{a[0, 1]}\t");
//            Console.Write($"{a[0, 2]}");
            
//            Console.Write($"\n{a[1, 0]}\t");
//            Console.Write($"{a[1, 1]}\t");
//            Console.Write($"{a[1, 2]}");

//            Console.Write($"\n{a[2, 0]}\t");
//            Console.Write($"{a[2, 1]}\t");
//            Console.Write($"{a[2, 2]}");
//            */
//            Console.WriteLine("Matrix is : ");
//            for (i = 0; i < 3; i++)
//            {
//                for (j = 0; j < 3; j++)
//                {
//                    Console.Write($"{a[i, j]}\t");
//                }
//                Console.WriteLine();
//            }
//        }
//    }
//}
///*
// Q1. Write a C# program to create a 3x3 matrix and display its transpose.
// Q2. Write a C# program to create a 3x3 matrix and display its left diagonal elements.
// Q3. Write a C# program to create a 3x3 matrix and display its right diagonal elements.
// Q4. Write a C# Program to create a 3x3 matrix and display its lower triangular elements.
// Q5. Write a C# Program to create a 3x3 matrix and display its upper triangular elements.
// Q6. Write a C# Program to create a 3x3 matrix and display its sum of all elements.
// Q7. Write a C# Program to create 2 matrix of 3x3 and display their sum.
// Q8. Write a C# Program to create 2 matrix of 3x3 and display their product.
 
// */