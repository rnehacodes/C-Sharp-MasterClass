namespace TernaryOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temperature;
            string output;
            Console.Write("Please Enter the temperature ");
            if(int.TryParse(Console.ReadLine(), out temperature))
            {
                output = temperature <= 15 ? "it is too cold here" : (temperature <= 28 ? "it is ok" : "it is hot here");
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine("Not a valid Temperature");
            }
        }
    }
}