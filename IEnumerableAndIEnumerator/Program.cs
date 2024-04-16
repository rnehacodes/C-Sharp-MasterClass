using System.Collections;

namespace IEnumerableAndIEnumerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DogShelter shelter = new DogShelter();
            Dog doggy = new Dog("Goofy", false);
            Console.WriteLine(doggy.Name);

            foreach (Dog dog in shelter.dogs)
            {
                if(dog.IsNaughty)
                {
                    dog.GiveTreat(1);
                }
                else
                {
                    dog.GiveTreat(2);
                }
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
    class DogShelter : IEnumerable<Dog>
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
        IEnumerator<Dog> IEnumerable<Dog>.GetEnumerator()
        {
            return dogs.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
