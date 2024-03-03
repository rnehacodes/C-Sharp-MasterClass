using System.Collections;

namespace ArrayLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===================ArrayList===================");
            //Declaring an ArrayList
            ArrayList ArrayList1 = new ArrayList();

            //Adding objects to ArrayList
            ArrayList1.Add(365);
            ArrayList1.Add('d');
            ArrayList1.Add("sdsagsagdf");
            ArrayList1.Add(547.23);
            ArrayList1.Add(231);
            ArrayList1.Add("string string");
            ArrayList1.Add('s');

            //Print the ArrayList initially
            Console.WriteLine("\nPrinting the array after adding objects");
            PrintArrayList(ArrayList1);

            //Make some modifications
            //Remove element
            ArrayList1.Remove('s');
            ArrayList1.Remove("sdsagsagdf");

            //Print the ArrayList
            Console.WriteLine("\nPrinting the array after modifying arraylist");
            PrintArrayList(ArrayList1);

            //Make some modifications
            //Remove element
            Console.WriteLine("\nPrinting the arraylist element: {0}", ArrayList1[0]); 
            ArrayList1.RemoveAt(0);

            //Print the ArrayList
            Console.WriteLine("\nPrinting the array after modifying arraylist again");
            PrintArrayList(ArrayList1);

            //Print the ArrayList element
            Console.WriteLine("\nPrinting the arraylist element: {0}", ArrayList1[0]);
        }

        private static void PrintArrayList(ArrayList list)
        {
            double sum = 0;

            foreach (object obj in list)
            {
                if (obj is int)
                {
                    sum += Convert.ToDouble(obj);
                }
                else if (obj is double)
                {
                    sum += (double)obj;
                }
                else
                {
                    Console.WriteLine(obj);
                }
            }
            Console.WriteLine(sum);
        }
    }
}
