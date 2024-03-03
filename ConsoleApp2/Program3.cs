namespace ConsoleApp2
{
    internal class Program3
    {
        static void Program3Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            double decimalNum = 15.6789243234;

            Console.WriteLine("The decimal number is " + decimalNum);

            int intNum;

            intNum = (int)decimalNum;

            Console.WriteLine("The int number is " + intNum);

            float myFloat = 12.86F;
            string myString;

            myString = myFloat.ToString();

            Console.WriteLine("The float number converted to string is: " + myString);

            bool myBool = false;

            myString = myBool.ToString();
            Console.WriteLine(myBool);
            Console.WriteLine("The boolean value converted to string is: " + myString);
        }
    }
}