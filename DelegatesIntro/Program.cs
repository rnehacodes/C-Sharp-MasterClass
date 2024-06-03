namespace DelegatesIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List of Names
            List<String> namesList = new List<String>() { "Tom", "Alan", "John", "Betty" };
            printStringList(namesList);
            
            namesList.RemoveAll(filter);

            printStringList(namesList);
        }

        static bool filter(string s)
        {
            return s.Contains("o");
        }

        static void printStringList(List<String> list)
        {
            foreach (String item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }        
    }
}
