namespace Stacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Initialising a Stack
            Stack<int> myStack = new Stack<int>();
            
            //Adding elements to the stack
            myStack.Push(45);
            myStack.Push(92);
            myStack.Push(30);
            myStack.Push(86);
            Console.WriteLine("Top value in the stack is : {0}", myStack.Peek());
            myStack.Push(29);
            Console.WriteLine("Top value in the stack is : {0}", myStack.Peek());
            myStack.Push(27);
            Console.WriteLine("Top value in the stack is : {0}", myStack.Peek());

            //Removing elements from the stack
            myStack.Pop();
            Console.WriteLine("After popping,the Top value in the stack is : {0} ", myStack.Peek());

            int element = myStack.Pop();
            Console.WriteLine("The element popped from the stack is {0}", element);

            //Removing elements from the stack until the stack get empty
            while(myStack.Count > 0)
            {
                Console.WriteLine($"Removed {myStack.Pop()} from the stack.");
            }

            int[] arr = new int[] { 8, 2, 3, 5, 6, 2, 7, 8, 3, 4, 5, 10};
            Stack<int> newStack = new Stack<int>();
            foreach (int num in arr)
            {
                Console.Write(num + " ");
                newStack.Push(num);
            }
            Console.WriteLine("\nThe numbers as stored in stack are:");
            while(newStack.Count > 0)
            {
                Console.Write(newStack.Pop() + " ");
            }

        }
    }
}
