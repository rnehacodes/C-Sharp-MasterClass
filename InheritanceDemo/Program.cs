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

            VideoPost videoPost1 = new VideoPost("My first video post", true, "User 2", "https://www.youtube.com/watch?v=9TlHvipP5yA", 74);
            Console.WriteLine(videoPost1);

            VideoPost videoPost2 = new VideoPost("My second video post", false, "User 3", "https://www.youtube.com/watch?v=Pno2hATcwHA&t=605s", 97);
            Console.WriteLine(videoPost2);

            videoPost1.Play();
            Console.WriteLine("Press any key to stop the video!");
            Console.ReadKey();
            videoPost1.Stop();
        }
    }
}
