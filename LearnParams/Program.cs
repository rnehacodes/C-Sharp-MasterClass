namespace LearnParams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numbers: 1, 43, 6, 2, 8, 79, 234, 23, 2, 9, 0, -32432, -4658, -245, 32436547, -6745");

            Console.WriteLine("MinimumOfAll");
            Console.WriteLine(MinimumOfAll(1, 43, 6, 2, 8, 79, 234, 23, 2, 9, 0, -32432, -4658, -245, 32436547, -6745));

            Console.WriteLine("MaximumOfAll");
            Console.WriteLine(MaximumOfAll(1, 43, 6, 2, 8, 79, 234, 23, 2, 9, 0, -32432, -4658, -245, 32436547, -6745));

            Console.WriteLine("UseParams1");
            UseParams1("sample", "text", "123", "safsfe", "     ", "areg43645\n");

            Console.WriteLine("UseParams2");
            UseParams2('\n', "not sample", 123, 'f', 3543.563, "     ", true);
        }

        private static int MaximumOfAll(params int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }

        private static int MinimumOfAll(params int[] arr)
        {
            int min = arr[0];
            for(int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }

        private static void UseParams1(params string[] arr)
        {
            foreach(string val in arr)
            {
                Console.Write(val + " ");
            }
        }

        private static void UseParams2(params object[] arr)
        {
            foreach (Object obj in arr)
            {
                Console.Write(obj + " ");
            }
        }
    }
}
