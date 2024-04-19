namespace IEnumerable3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6};

            Queue<int> queue = new Queue<int>();

            queue.Enqueue(11);
            queue.Enqueue(12);
            queue.Enqueue(13);
            queue.Enqueue(14);

            int[] array = new int[]
            {
                4, 5, 6
            };

            CollectionSum(list);
            CollectionSum(queue);
            CollectionSum(array);
        }
        static void CollectionSum(IEnumerable<int> anyCollection)
        {
            int sum = 0;
            foreach (int i in anyCollection)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }
    }
}
