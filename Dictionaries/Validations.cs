namespace Dictionaries
{

    class Validations
    {
        public static void integerValidation(string inputString, out int num)
        {
            bool runLoop = true;
            num = 0;
            while(runLoop)
            {
                try
                {
                    num = int.Parse(inputString);
                    runLoop = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Invalid input. Please enter a valid number.");
                    inputString = Console.ReadLine();
                }
            }
        }
    }
}