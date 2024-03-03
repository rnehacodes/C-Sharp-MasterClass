using System;

namespace TryAndCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            string userInput = Console.ReadLine();
            int num;

            try
            {
                num = int.Parse(userInput);
            }
            catch (Exception)
            {

                Console.WriteLine("You have mistakenly enter a non-number character. Please enter the number!");
            }
            finally
            {
                Console.WriteLine(num);
            }            

            Console.ReadKey();
        }
    }
}