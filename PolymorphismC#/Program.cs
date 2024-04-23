namespace PolymorphismC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car(500, "blue");
            car1.ShowDetails();
            car1.Repair();
            car1.SetCarIDInfo(67, "Ram");
            car1.GetCarIDInfo();

            Console.WriteLine();

            BMW bmw1 = new BMW("A1", 500, "black");
            bmw1.ShowDetails();
            bmw1.Repair();
            bmw1.SetCarIDInfo(88, "Sukriti");
            bmw1.GetCarIDInfo();

            Console.WriteLine();

            Audi audi1 = new Audi("B1", 700, "PURPLE");
            audi1.ShowDetails();
            audi1.Repair();

            Console.WriteLine();

            var cars = new List<Car>()
            {
                new BMW("F3", 400, "yellow"),
                new Audi("F1", 700, "red")
            };

            foreach(var Car in cars)
            {
                Car.ShowDetails();
                Car.Repair();
            }

            Console.WriteLine();

            Car bmw3 = new BMW("Z7", 940, "Silver");
            bmw3.ShowDetails(); bmw3.Repair();

            Console.WriteLine();

            BMW newBMW = new BMW("H8", 870, "Silver");
            newBMW.ShowDetails();

            Console.WriteLine();

            Car carB = (Car)newBMW;
            carB.ShowDetails();
        }
    }
}
