namespace InterfacesPart1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ticket t1 = new Ticket(4);
            Ticket t2 = new Ticket(4);
            Console.WriteLine(t1.Equals(t2));
        }
    }
}
