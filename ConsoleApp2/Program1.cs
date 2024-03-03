namespace ConsoleApp2
{
    internal class Program1
    {
        public static void Main()
        {
            /*
            string stringForFloat = "0.85"; // datatype should be float
            string stringForInt = "12345"; // datatype should be int

            float floatFromString = float.Parse(stringForFloat);
            Console.WriteLine(stringForFloat);

            int intFromString = int.Parse(stringForInt);
            Console.WriteLine(intFromString);
            */

            //String Manipulation

            /*
            
            string name = "Neha";

            int age = 21;

            //1. String Concantenation
            Console.WriteLine("String Concantenantion Example");
            Console.WriteLine("My name is " + name + ". My age is " + age + ".");

            Console.WriteLine();

            //2. String Formatting
            Console.WriteLine("String Formatting");
            Console.WriteLine("My name is {0}. My age is {1}.\n", name, age);

            //3. String Interpolation
            Console.WriteLine("String Interpolation");
            Console.WriteLine($"My name is {name}. My age is {age}.", name, age);

            //4. Verbatim Strings
            Console.WriteLine("Verbatim Strings");
            Console.WriteLine(@"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation 
            ullamco laboris nisi ut aliquip ex ea commod
o consequat. Duis aute irure dolor in reprehenderit in
            
            v   oluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non

                 proident, sunt in culpa qui officia deserunt mollit anim id est laborum.");
            */

            string firstName = "TEST";
            string lastName = "USER";

            string fullName;

            fullName = string.Concat("     ", firstName, " ", lastName);

            /*
            Console.WriteLine(fullName);

            Console.WriteLine(fullName.Substring(6));

            Console.WriteLine(firstName.ToLower() + " " + lastName.ToUpper());

            Console.WriteLine(fullName.Trim());

            int occurence = firstName.IndexOfAny({ 'T', 'X'});

            Console.WriteLine(occurence);
            */

            Console.WriteLine("String is null or whitespace");
            Console.WriteLine(string.IsNullOrWhiteSpace(fullName));

        }
    }
}