using System.Collections.Generic;

namespace IEnumerable2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> collection;
            collection = GetCollection(2);
            foreach(int i in collection)
            {
                Console.WriteLine(i);
            }
        }
        static IEnumerable<int> GetCollection(int option)
        {
            List<int> numbersList = new List<int>() { 1, 2, 3, 4, 5 };

            Queue<int> queue = new Queue<int>();

            queue.Enqueue(6);
            queue.Enqueue(7);
            queue.Enqueue(8);
            queue.Enqueue(9);
            queue.Enqueue(10);

            Stack<int> stack = new Stack<int>();

            stack.Push(11);
            stack.Push(12);
            stack.Push(13);
            stack.Push(14);
            stack.Push(15);

            switch(option)
            {
                case 1:
                    return numbersList;
                    break;

                case 2:
                    return queue;
                    break;

                case 3:
                    return stack;
                    break;

                default:
                    return null;
            }
        }
    }    
}
