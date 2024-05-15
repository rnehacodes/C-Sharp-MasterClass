namespace DateTimeLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(2023, 12, 01);
            Console.WriteLine($"Date: {dateTime}\n");

            DateTime dateTimeToday = DateTime.Today;
            Console.WriteLine($"Date: {dateTimeToday}\n");

            DateTime dateTimeTomorrow = GetTomorrow();
            Console.WriteLine($"Date: {dateTimeTomorrow}\n");

            DateTime firstdayOfYear = GetFirstDayoftheYear(2025);
            Console.WriteLine($"Date: {dateTimeTomorrow}\n");

            DateTime currentDateTime = DateTime.Now;
            Console.WriteLine($"The date & time right now is {currentDateTime}\n");
        }

        private static DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }

        private static DateTime GetFirstDayoftheYear(int year)
        {
            return new DateTime(year, 1, 1);
        }
    }
}
