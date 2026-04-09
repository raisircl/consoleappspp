//using Microsoft.VisualBasic;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace ConsoleApp1
//{
//    //call by value
//    //call by reference
//    //call by out

//    internal class Functions
//    {
//        static void Main()
//        {
//            msg();
//            table(5);   
//            Console.WriteLine($"Factorial of 5 is {factorial(5)}");
//            Console.WriteLine($"Value of pi is {getpi()}");

//            int x = 10, y = 20; // actual parameters
//            Console.WriteLine($"Before swap: x = {x}, y = {y}");
//                //swap(x, y);
//                swapref(ref x, ref y);
//            Console.WriteLine($"After swap: x = {x}, y = {y}");
//            int hindi = 85, eng = 90, math = 95, sci = 80, sst = 88;
//            int total;
//            double p;
//            Result(hindi, eng, math, sci, sst, out total, out p);
//            Console.WriteLine($"Total Marks: {total}, Percentage: {p}%");
//        }
//        static void swap(int a, int b) // call by value - a and b formal parameters
//        {
//            int temp = a;  // in call by value, changes to a and b do not affect x and y in Main
//            a = b;
//            b = temp;
//        }
//        static void swapref(ref int a, ref int b) // call by reference - a and b formal parameters
//        {
//            int temp = a;  // in call by reference, changes to a and b will affect x and y in Main
//            a = b;
//            b = temp;
//        }
//        //call by out is used when we want to return multiple values from a method. It allows us to pass parameters that will be assigned values within the method and returned to the caller.
//        static void Result(int hindi, int eng, int math, int sci, int sst, out int total, out double percentage)
//        {
//            total = hindi + eng + math + sci + sst;
//            percentage = (total / 500.0) * 100;
//        }
//        static void msg()
//        {
//            Console.WriteLine("Hello World");
//        }
//        static void table(int num)
//        {
//            for (int i = 1; i <= 10; i++)
//            {
//                Console.WriteLine($"{num} x {i} = {num * i}");
//            }
//        }
//        static int factorial(int n)
//        {
//            if (n == 0)
//                return 1;
//            else
//                return n * factorial(n - 1);
//        }
//        static double getpi()
//        {
//            return 3.14;
//        }
//    }
//}
