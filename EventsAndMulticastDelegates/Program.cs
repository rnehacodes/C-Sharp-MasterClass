namespace EventsAndMulticastDelegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AudioSystem audioSystem = new AudioSystem();
            RenderingEngine renderingEngine = new RenderingEngine();

            Player player1 = new Player("John_Doe");
            Player player2 = new Player("Anne_Wood");

            GameEventManager.TriggerGameStart();

            Console.WriteLine("Game is running...press any key to stop it!");

            Console.ReadLine();

            GameEventManager.TriggerGameStop();
        }

    }
}
