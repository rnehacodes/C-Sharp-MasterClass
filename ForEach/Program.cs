namespace ForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] myFriend = {"Friend 1", "Friend 2", "Friend 3", "Friend 4", "Friend 5", "Friend 6"};
            int i = 0;

            foreach (var friend in myFriend)
            {
                Console.WriteLine("Hello {0}, my friend!", friend);
                i++;
            }
            Console.ReadKey();
        }
    }
}