using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int num1 = 3;
            //int num2 = 4;
            //int num3;

            //num3 = -num2;

            //Console.WriteLine("Using the unary minus(-) operator, {0} turned to {1}", num2, num3);

            //bool isRaining = false;
            //bool oppositeBool = !isRaining;

            //Console.WriteLine("Using the NOT(!) operator, {0} turned to {1}", isRaining, oppositeBool);

            //num3 = ++num1;

            //Console.WriteLine("Using the increment(++) operator, {0} turned to {1}", num1, num3);

            //Console.ReadKey();

            int num1 = 3;
            int num2 = 4;
            int num3;

            num3 = -num2;

            Console.WriteLine("Using the unary minus(-) operator, {0} turned to {1}", num2, num3);

            bool isRaining = false;
            bool oppositeBool = !isRaining;

            Console.WriteLine("Using the NOT(!) operator, {0} turned to {1}", isRaining, oppositeBool);

            num3 = num1++;

            Console.WriteLine("Using the increment(++) operator, {0} turned to {1}", num1, num3);

            Console.ReadKey();

        }
    }
}
