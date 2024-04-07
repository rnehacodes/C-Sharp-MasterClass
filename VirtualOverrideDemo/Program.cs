namespace VirtualOverrideDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog mydog = new Dog("Goofy", 3);
            Console.WriteLine($"{mydog.Name} is {mydog.Age} years old!");
            mydog.Eat();
            mydog.Play();
            mydog.MakeSound();
        }
    }
}
