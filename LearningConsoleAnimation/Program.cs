namespace LearningConsoleAnimation
{
    internal class Program
    {
        //rotating line animation
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Rotating line animation:");

        //    int counter = 0;
        //    while (true)
        //    {
        //        counter++;

        //        Console.Write("|");

        //        switch (counter % 4)
        //        {
        //            case 0:
        //                Console.Write("/");
        //                break;
        //            case 1:
        //                Console.Write("-");
        //                break;
        //            case 2:
        //                Console.Write("\\");
        //                break;
        //            case 3:
        //                Console.Write("|");
        //                break;
        //        }

        //        Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
        //        Thread.Sleep(100);
        //    }

        //}



        //spinning wheel animation
        static void Main(string[] args)
        {
            Console.WriteLine("Spinning wheel animation:");

            //int counter = 0;
            //while (true)
            //{
            //    counter++;

            //    switch (counter % 4)
            //    {
            //        case 0:
            //            Console.Write("/");
            //            break;
            //        case 1:
            //            Console.Write("-");
            //            break;
            //        case 2:
            //            Console.Write("\\");
            //            break;
            //        case 3:
            //            Console.Write("|");
            //            break;
            //    }

            //    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            //    Thread.Sleep(100);
            //}

            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 16; j++)
                {
                    Console.Write("*");
                    Thread.Sleep(25);
                }
                Console.WriteLine();
            }
        }

        //another animation
        //static void Main()
        //{
        //    Console.WindowHeight = 16;
        //    Console.WindowWidth = 32;
        //    Console.BufferHeight = 16;
        //    Console.BufferWidth = 32;

        //    int x = 0;

        //    while (true)
        //    {
        //        Console.Clear();
        //        Console.SetCursorPosition(x, 0);
        //        Console.Write("o");

        //        // Adjust the speed of the animation
        //        Thread.Sleep(100);

        //        // Move the 'o' character to the right
        //        x = (x + 1) % Console.BufferWidth;
        //    }
        //}

    }
}
