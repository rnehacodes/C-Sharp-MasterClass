namespace NUllables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Nullable<int> nullableStructInt = null;
            string? nullString = null;

            Console.WriteLine($"Nullable struct integer : <{nullableStructInt}>. Nullable '?' operator string : <{nullString}>");

            nullableStructInt = 5672;
            nullString = "Test String";

            Console.WriteLine($"Nullable struct integer : <{nullableStructInt}>. Nullable '?' operator string : <{nullString}>");

            bool? nullBool = null;
            bool? notNullBool = false;

            Console.WriteLine($"Nullable bool : <{nullBool}>. Not nullable bool : <{notNullBool}>");

            if(notNullBool.HasValue )
            {
                Console.WriteLine($"Not nullable bool : <{notNullBool.Value}>");
            }

            char? nullChar = null;
            Console.WriteLine($"Here's what the nullChar looks like : {nullChar}.");

            char nonNullChar1 = nullChar ?? 't';
            Console.WriteLine($"Here's what the nonNullChar1 looks like after Null-Coalescing : {nonNullChar1}.");

            nullChar = 'a';
            char nonNullChar2 = nullChar ?? 't';
            Console.WriteLine($"Here's what the nonNullChar2 looks like after Null-Coalescing : {nonNullChar2}.");

            double? nullDouble = null;
            Console.WriteLine($"Here's what the nullDouble looks like : {nullDouble}.");

            nullDouble ??= 3.14;
            Console.WriteLine($"Here's what the nullDouble looks like after using Null-Coalescing Assignment Operator : {nullDouble}.");

            double? nonNullDouble = 9.21;
            Console.WriteLine($"Here's what the nonNullDouble looks like : {nonNullDouble}.");

            nonNullDouble ??= 3.14;
            Console.WriteLine($"Here's what the nonNullDouble looks like after using Null-Coalescing Assignment Operator : {nonNullDouble}.");
        }
    }
}
