namespace ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;

            for(i = 1; i<20; i+=2)
            {
                Console.WriteLine(i + " is an odd number and is less than 20");
            }
            Console.ReadKey();
        }
    }
}