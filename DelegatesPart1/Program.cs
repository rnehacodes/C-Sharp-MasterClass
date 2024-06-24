namespace DelegatesPart1
{
    internal class Program
    {
        public delegate bool FilterDelegate(Person person);
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>()
            {
                new Person("Alice", 23),
                new Person("John", 46),
                new Person("Anna", 80),
                new Person("Jack", 3),
                new Person("Bob", 67),
                new Person("Marie", 35),
                new Person("Alexa", 15),
                new Person("Bixby", 27),
                new Person("Noah", 19),
                new Person("Lyla", 30),
                new Person("Tom", 23),
                new Person("Hanna", 35)
            };

            Console.WriteLine("List of minor people: ");
            DisplayPeople(persons, IsMinor);

            Console.WriteLine("List of young people: ");
            DisplayPeople(persons, IsYoung);

            Console.WriteLine("List of old people: ");
            DisplayPeople(persons, IsOld);

            //Anonymous Methods
            FilterDelegate filter = delegate (Person person)
            {
                return person.Age >= 20 && person.Age <= 30;
            };
            Console.WriteLine("List of ideal working 20s working population:");
            DisplayPeople(persons, filter);

            Console.WriteLine("All people list:");
            DisplayPeople(persons, delegate (Person p) { return true; });

            //Lamba Expression
            //Statement Lambda
            Console.WriteLine("List of people containing 'n' in their name: ");
            DisplayPeople(persons, (p) =>
            {
                return p.Name.Contains("n") || p.Name.Contains("N");
            });

            //Expression Lambda
            Console.WriteLine("List of people having age less than 20 yrs: ");
            DisplayPeople(persons, p => p.Age < 20);
        }
        static void DisplayPeople(List<Person> people, FilterDelegate filter)
        {
            foreach (Person person in people)
            {
                if (filter(person))
                {
                    Console.WriteLine($"Name : {person.Name}, Age : {person.Age}");
                }
            }
            Console.WriteLine();
        }

        static bool IsMinor(Person p)
        {
            return p.Age < 18;
        }

        static bool IsYoung(Person p)
        {
            return p.Age >= 18 && p.Age < 60;
        }

        static bool IsOld(Person p)
        {
            return p.Age >= 60;
        }
    }
}
