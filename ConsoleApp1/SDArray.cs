using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class SDArray
    {
        // Array collection of items of same type of data
        // Syntax: dataType[] arrayName = new dataType[size];
        static void Main()
        {
            int[] a = new int[5]; // declaration and instantiation of array
            int i;

            /*a[0] = 100; // initialization of array
            a[1] = 200;
            a[2] = 300;
            a[3] = 400;
            a[4] = 500;
            */
            for (i = 0; i < 5; i++) // last element of array is always size-1
            {
                Console.WriteLine("Enter element {0} of array:", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Accessing array elements
            /*
            Console.WriteLine(a[0]);
            Console.WriteLine(a[1]);
            Console.WriteLine(a[2]);
            Console.WriteLine(a[3]);
            Console.WriteLine(a[4]);
            */
            Console.WriteLine("Elements of array are:");
            int x = 0;
            int y = 0;

            for (i = 0; i < 5; i++)
            {
                x = x + a[i];
                Console.WriteLine(a[i]);
                if (y < a[i])
                {
                    y = a[i];
                }
            }
            Console.WriteLine("Sum of array elements is: {0}", x);
            Console.WriteLine("Largest element of array is: {0}", y);



            int z;
            Console.WriteLine("Enter element to search in array:");
            z = Convert.ToInt32(Console.ReadLine());
            bool found = false;
            for (i = 0; i < a.Length; i++)
            {
                if (z == a[i])
                {
                    found = true;
                    break;
                }
            }
            if (found)
            {
                Console.WriteLine($"Element {z} is found at {i} in array.");
            }
            else
            {
                Console.WriteLine("Element {0} is not found in array.", z);
            }
            int temp;
            for (i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted array is:");
            for (i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}
// search an element in arrant and count number of times it is present in array
//Reverse an Array: Print elements in reverse order or physically reverse their positions in the array.
//Copy Arrays: Create a copy of one array into another or copy just a specific section.
//Merge Arrays: Take two sorted arrays and merge them into a single sorted third array.
//Separate Even and Odd: Scan an array and split its elements into two separate arrays: one for even and one for odd numbers.
