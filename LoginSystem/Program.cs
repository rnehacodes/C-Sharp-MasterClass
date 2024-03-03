namespace LoginSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome to Neha's App\nAs a new user, please complete the registration process.\nPlease enter the following:\nUSERNAME: ");
            string username = Console.ReadLine();
            Console.Write("PASSWORD: ");
            string password = Console.ReadLine();

            Console.Write("Now You can login into the app. Please enter the following:\nUSERNAME: ");
            string enteredUsername = Console.ReadLine();
            Console.Write("PASSWORD: ");
            string enteredPassword = Console.ReadLine();

            bool result;

            if(enteredUsername == username && enteredPassword == password)
            {
                Console.WriteLine("Credentials matched! You have logged in successfully.");
            }
            else
            {
                Console.WriteLine("Credentials did not match! Failed to login.");
            }

            Console.ReadKey();
        }
    }
}