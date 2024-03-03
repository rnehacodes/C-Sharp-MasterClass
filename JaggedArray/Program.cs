namespace JaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[][] familyMembers = new string[][]
            {
                new string[] {"Phineas", "Ferb", "Candace"},
                new string[] {"Baljeet", "Isabella", "Dufensmirtz"},
                new string[] {"Shinchan", "Himawari", "Masai", "Hiroshi", "Shero"}
            };

            for(int i = 0; i < familyMembers.Length; i++)
            {
                for(int j = 0; j < familyMembers[i].Length; j++)
                {
                    Console.WriteLine("Hi! I am {0}", familyMembers[i][j]);
                }
                Console.WriteLine("");
            }
        }
    }
}
