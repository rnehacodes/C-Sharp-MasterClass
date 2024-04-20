namespace PolymorphismC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car(500, "blue");
            car1.ShowDetails();
            car1.Repair();

            BMW bmw1 = new BMW("A1", 500, "black");
            bmw1.ShowDetails();
            bmw1.Repair();

            Audi audi1 = new Audi("B1", 700, "PURPLE");
            audi1.ShowDetails();
            audi1.Repair();

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

            Car bmw3 = new BMW("Z7", 940, "Silver");
            bmw3.ShowDetails(); bmw3.Repair();

            BMW newBMW = new BMW("H8", 870, "Silver");
            newBMW.ShowDetails(); newBMW.Repair();
        }
    }
}
