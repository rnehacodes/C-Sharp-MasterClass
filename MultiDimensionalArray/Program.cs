using System;

namespace MultiDimensionalArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare 2D array
            //int[,] arr;

            //declare 3D array
            //string[,,] arr2;

            //initialize a 3D interger array with elements
            int[,,] num3D = new int[,,]
            {
                {
                    {1, 2, 3, 4, 5},
                    {6, 7, 8, 9, 10},
                    {11, 12, 13, 14, 16}
                },
                {
                    {11, 12, 13, 14, 15},
                    {16, 17, 18, 19, 10},
                    {111, 112, 113, 114, 116}
                }
            };

            Console.WriteLine($"The num3D array has {num3D.Length} elements\n"); 
            Console.WriteLine("Printing using foreach loop.\n=================================");
            int i = 1;
            foreach (int num in num3D)
            {
                Console.WriteLine($"The {i}th element of num3D array is {num}");
                i++;
            }
            //Console.WriteLine($"Central value of num3D array is {num3D[1, 2, ]}\n");
            Console.WriteLine("\nPrinting using nested for loop.\n=================================");

            int m, n, o;
            for (m = 0; m < num3D.GetLength(0); m++) 
            {
                for (n = 0; n < num3D.GetLength(1); n++)
                {
                    for (o = 0; o < num3D.GetLength(2); o++)
                    {
                        Console.Write(num3D[m, n, o] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}