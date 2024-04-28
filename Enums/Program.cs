namespace Enums
{
    enum Day { Mon, Tue, Wed, Thu, fri, Sat, Sun};
    enum Month { Jan = 2401, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec};
    internal class Program
    {
        static void Main(string[] args)
        {
            Day today = Day.Sun;
            Day test = Day.Mon;
            Day test2 = Day.Sun;

            Console.WriteLine(today == test);
            Console.WriteLine(today == test2);
            Console.WriteLine(today);
            Console.WriteLine((int)test);

            Console.WriteLine((int)Month.Dec);
        }
    }
}
