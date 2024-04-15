namespace IEnumerableAndIEnumerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DogShelter shelter = new DogShelter();

            foreach(Dog dog in shelter)
            {
                //
            }
        }
    }

    class Dog
    {
        public string Name { get; set; }
        public bool IsNaughty { get; set; }
        public Dog(string name, bool isNaughty)
        {
            Name = name;
            IsNaughty = isNaughty;
        }
        public void GiveTreat(int numberOfTreats)
        {
            Console.WriteLine("Dog: {0} said wuoff {1} times!.", Name, numberOfTreats);
        }
    }
    class DogShelter
    {
        public List<Dog> dogs;
        public DogShelter()
        {
            dogs = new List<Dog>()
            {
                new Dog("Casper", false),
                new Dog("Olie", true),
                new Dog("Vinni", true),
                new Dog("Goofy", false)
            };
        }
    }
}
