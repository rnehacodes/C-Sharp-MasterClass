namespace InheritanceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("Welcome to my first post", true, "User1");
            Console.WriteLine(post1);

            ImagePost imagePost1 = new ImagePost("My find first picture", "User1", "resource/post.com", true);
            Console.WriteLine(imagePost1);
        }
    }
}
