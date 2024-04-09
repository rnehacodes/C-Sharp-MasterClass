using System;

namespace Program3
{
    class UserInput    
    {
        static void Main()
        {
            Console.WriteLine($"The sum of the numbers you entered is {giveSum()}");
            
            Console.ReadKey();
        }

        static int giveSum()
        {
            Console.Write("Enter your first number: ");
            string input1 = Console.ReadLine();

            //Convert first input to int type
            int num1 = int.Parse(input1);

            //Input Second number
            Console.Write("Enter your second number: ");
            string input2 = Console.ReadLine();

            //Convert second input to int type
            int num2 = int.Parse(input2); 
            
            return num1 + num2;
        }
    }
}
