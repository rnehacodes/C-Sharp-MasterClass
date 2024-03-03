//using System;
//using System.Linq.Expressions;

//namespace FunctionsAndMethoda
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string friend1 = "Shruti", friend2 = "Simmi", friend3 = "Riya", input;
//            //GreetFriend(friend2);

//            Console.WriteLine("Which friend you'd like to message?\nEnter 1 for Shruti, 2 for Simmi & 3 for Riya!!!!!!");
//            input = Console.ReadLine();
//            int num = int.Parse(input);
//            Console.WriteLine($"You have chose {num}. Here is your message:");
//            switch (num)
//            {
//                case 1:
//                    GreetFriend(friend1);
//                    break;
//                case 2:
//                    GreetFriend(friend2);
//                    break;
//                case 3:
//                    GreetFriend(friend3);
//                    break;
//            }
//        }

//        public static void GreetFriend(string friendName)
//        {
//            Console.WriteLine($"Hi {friendName}, my friend!");
//        }
//        public static void AWriteMethodWithArgs(string args)
//        {
//            Console.WriteLine($"AWriteMethodWithArgs was called with an argument : {args}");
//        }
//        public static void AWriteMethod () 
//        {
//            Console.WriteLine("AWriteMethod has been called");
//        }
        
        
//    }
//}