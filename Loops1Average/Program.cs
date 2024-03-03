namespace Loops1Average
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to this smart Application\nTo calculate the average, enter all the numbers below by pressing 'Enter'.");
            float num, sum = 0, n = 0;
            string input = "";
            bool isParsed;
            float avg;
            input = Console.ReadLine();
            while (input != "-1")
            {
                isParsed = float.TryParse(input, out num);
                if (isParsed == true)
                {
                    if(num > 20 || num <= -1)
                    {
                        Console.WriteLine("You have entered an incorrect score i.e. not between 0 & 20");
                    }
                    else
                    {
                        sum += num;
                        n++;
                    }
                }
                else
                {
                    Console.WriteLine("You have entered an invalid score. Please enter a number between 0 & 20");
                }
                input = Console.ReadLine();
            }
            avg = sum / n;
            Console.WriteLine("The average of the scores you entered is " + avg);
        }
    }
}