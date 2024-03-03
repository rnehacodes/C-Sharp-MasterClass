namespace PlayerHighScore
{
    internal class Program
    {
        public static int highscore = 90;
        public static string highscorePlayer = "A";
        static void Main(string[] args)
        {
            CheckScore(59, "B");
        }

        public static void CheckScore(int score, string playerName)
        {
            if(score>highscore)
            {
                Console.WriteLine("New highscore is = " + score + "\nNew highscore holder is = " + playerName);
            }
            else
            {
                Console.WriteLine("The old highscore of " + highscore + " could not be broken and is still held by " + highscorePlayer);
            }
        }
    }
}