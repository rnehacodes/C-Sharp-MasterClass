namespace InterfacesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chair officeChair = new Chair("Black", "Plastic");
            Chair gamingChair = new Chair("Brown", "Cushion Material");

            Car damagedCar = new Car(150f, "Yellow");

            damagedCar.DestroyablesNearby.Add(officeChair);
            damagedCar.DestroyablesNearby.Add(gamingChair);

            damagedCar.Destroy();
        }
    }
}
