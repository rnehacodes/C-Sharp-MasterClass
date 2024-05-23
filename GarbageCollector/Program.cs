namespace GarbageCollector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            Console.WriteLine("Value of a before calling garbage collector method: "+ a);

            GC.Collect();

            Console.WriteLine("Value of a after calling garbage collector method: " + a);
        }
    }
}
