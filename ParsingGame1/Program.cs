using System.Data.SqlTypes;

namespace ParsingGame1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fileLines = System.IO.File.ReadAllLines(@"C:\Users\neha.rajput\Desktop\Learning\C#MasterClass\ParsingGame1\input.txt");
            string outputText = "";
            foreach(string line in fileLines)
            {
                if (line.Contains("split"))
                {
                    string[] splitLine = line.Split(" ");
                    string enterText = splitLine[4];
                    if(outputText == "")
                    {
                        outputText = enterText;
                    }
                    else
                    {
                        outputText = outputText + " " + enterText;
                    }
                }
            }
            File.WriteAllText(@"C:\Users\neha.rajput\Desktop\Learning\C#MasterClass\ParsingGame1\FileOutput\" + "output" + ".txt", outputText);
        }
    }
}
