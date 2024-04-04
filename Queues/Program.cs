namespace Queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Part 1 - Basics*/
            Console.WriteLine("~~~~~~~~~~~~~~~~Part 1 - Basics~~~~~~~~~~~~~~~~");

            //Initializing Queue
            Queue<int> myQueue = new Queue<int>();

            //Adding an element to the Queue
            myQueue.Enqueue(1);

            //Fetching the element from Queue (fetches the first inserted element of the queue)
            Console.WriteLine("The value at the begining of the Queue is : {0}", myQueue.Peek());

            for (int i = 2; i < 10; i++)
            {
                myQueue.Enqueue(i);
            }

            while (myQueue.Count > 0)
            {
                Console.WriteLine("The value at the begining of the Queue is : {0}", myQueue.Peek());
                myQueue.Dequeue();
            }

            /*Part 2 - Intermediate*/
            Console.WriteLine("\n~~~~~~~~~~~~~~~~Part 1 - Intermediate~~~~~~~~~~~~~~~~");
            Queue<Order> orderQueue = new Queue<Order>();
            foreach (Order order in RecieveOrdersFromBranch1())
            {
                orderQueue.Enqueue(order);
            }

            foreach (Order order in RecieveOrdersFromBranch2())
            {
                orderQueue.Enqueue(order);
            }

            while(orderQueue.Count > 0)
            {
                Console.WriteLine("Current Order: {0}.\nStatus : Delivered!", orderQueue.Dequeue());
            }
        }

        static Order[] RecieveOrdersFromBranch1()
        {
            Order[] orders = new Order[]
            {
                new Order(1, 5),
                new Order(2, 3),
                new Order(6, 8)
            };
            return orders;
        }

        static Order[] RecieveOrdersFromBranch2()
        {
            Order[] orders = new Order[]
            {
                new Order(3, 14),
                new Order(4, 8),
                new Order(5, 10)
            };
            return orders;
        }
    }
}
