namespace InheritanceChallenge2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Alex Abott", "Alex", 55000);
            Console.WriteLine(employee1);
            employee1.Work();
            employee1.Pause();
            Boss boss = new Boss("Allan Hawking", "Allen", 79000, "Hyundai");
            Console.WriteLine(boss);
            boss.Lead();
            Trainees trainee1 = new Trainees("Marissa Wood", "Marissa", 10000, 3, 4);
            Console.WriteLine(trainee1);
            trainee1.Learn();
            trainee1.Work();
        }
    }
}
