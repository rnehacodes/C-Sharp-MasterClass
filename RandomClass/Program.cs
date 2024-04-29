namespace RandomClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random lottery = new Random();
            for(int i = 0; i < 12; i++)
            {
                Console.WriteLine("Enter your lottery ticket number: ");
                int num = int.Parse(Console.ReadLine());
                int lotteryNum = lottery.Next(0, 12);
                if(lotteryNum == num)
                {
                    Console.WriteLine("Yayyyy, you won the lottery!!!!");
                    break;
                }
                else
                {
                    Console.WriteLine("Better luck next time! The lottery number was {0} and your number was {1}", lotteryNum, num
                        );
                }
            }
        }
    }
}
