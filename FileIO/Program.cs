namespace FileIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Reading from a file
            string fileText = System.IO.File.ReadAllText(@"C:\Users\neha.rajput\Desktop\Learning\C#MasterClass\FileIO\fileInput.txt");

            Console.WriteLine("Here is the content of the text file: \n\n{0}", fileText);

            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\neha.rajput\Desktop\Learning\C#MasterClass\FileIO\fileInput.txt");

            //Console.WriteLine("\n\n\nThe file has the following lines:\n\n");
            //foreach (string line in lines)
            //{
            //    Console.WriteLine("\t" + line);
            //}

            //Writing into the file
            string[] fileInput = { "Line 1....", "LIne 2......", "Line 3......" };

            File.WriteAllLines(@"C:\Users\neha.rajput\Desktop\Learning\C#MasterClass\FileIO\fileInput.txt", fileInput);
            fileText = System.IO.File.ReadAllText(@"C:\Users\neha.rajput\Desktop\Learning\C#MasterClass\FileIO\fileInput.txt");
            Console.WriteLine("\n\n\nHere is the updated content of the text file: \n\n{0}", fileText);

            //Creating text files
            //Console.WriteLine("\n\n\nPlease enter your file name: ");
            //string fileName = Console.ReadLine();
            //Console.WriteLine("\nPlease enter the content for your file:\n\n");
            //string fileContent = Console.ReadLine();
            //File.WriteAllText(@"C:\Users\neha.rajput\Desktop\Learning\C#MasterClass\FileIO\" + fileName + ".txt", fileContent);

            using (StreamWriter file = new StreamWriter(@"C:\Users\neha.rajput\Desktop\Learning\C#MasterClass\FileIO\fileInput.txt", true))
            {
                foreach (string line in lines)
                {
                    file.WriteLine("new line");
                    //if (line.Contains("2"))
                    //{
                    //    file.WriteLine("new line");
                    //}
                }
            }
        }
    }
}
