﻿namespace DoWhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int i = -10;

            Console.WriteLine(-9 % 3);

            while (true)
                {
                    if (i % 3 == 0)
                    {
                        i++;
                        continue;
                    }
                    if (i == 10)
                    {
                        break;
                    }
                    // TODO
                    if (i == 11)
                    {
                        Console.WriteLine(" FINAL BREAK REACHED! This should not happen!");
                        break;
                    }
                    Console.WriteLine(i++);

                }

        }
    }
}