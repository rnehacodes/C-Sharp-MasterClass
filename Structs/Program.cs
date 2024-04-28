namespace Structs
{
    internal class Program
    {
        struct Game
        {
            public string Name;
            public string Description;
            public Game(string name, string description)
            {
                Name = name;
                Description = description;
            }
            public override string ToString()
            {
                return $"Game Name: {Name}\nGame Description: {Description}";
            }
        }
        static void Main(string[] args)
        {
            Game myGame = new Game();
            myGame.Name = "Test";
            myGame.Description = "Test game's test description";

            Console.WriteLine(myGame);
        }
    }
}
