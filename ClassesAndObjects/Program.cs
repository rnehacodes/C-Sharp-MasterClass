namespace ClassesAndObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ask the user to choose the type of vehicle
            Console.WriteLine("Welcome to the Vehicle Game!\nEnter the following numbers to create the respective vehicle\n1 - Car\n2 - Bus\n3 - Train\n-------------------------------------------------------------");

            string vehicleTypeedit = "";
            int option = 0;
            bool isTrue = false;

            //Take input from the user
            while(isTrue == false)
            {
                isTrue = int.TryParse(Console.ReadLine(), out option);
                if(isTrue == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("You have entered an invalid input. Please enter a numeric value between 1 & 3");
                    Console.ResetColor();
                }
                else
                {
                    //Choose the type of vehicle
                    switch (option)
                    {
                        case 1:
                            vehicleTypeedit = "Car";
                            break;

                        case 2:
                            vehicleTypeedit = "Bus"; 
                            break;

                        case 3:
                            vehicleTypeedit = "Train"; 
                            break;

                        default:
                            //Run the loop again when the number entered is not within the valid range
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.WriteLine("You have entered an invalid number. Please enter a value between 1 & 3");
                            Console.ResetColor();
                            isTrue = false;
                            break;
                    }
                }
            }

            Console.WriteLine("You have chosen " + vehicleTypeedit + "\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Please enter a name for your vehicle: ");
            VehicleEdit myVehicle = new VehicleEdit(Console.ReadLine());

            //Ask the user to choose the type of operation to be performed on vehicle
            Console.WriteLine("Now, please choose the operation you wish to perform on the vehicle, from the following choices!\n1 - Start\n2 - Run\n3 - Stop\n-------------------------------------------------------------");

            //Choose the operation to be performed on vehicle
            option = 0;
            while (option != 3)
            {
                isTrue = int.TryParse(Console.ReadLine(), out option);
                if (isTrue == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("You have entered an invalid input. Please enter a numeric value between 1 & 3");
                    Console.ResetColor();
                }
                else
                {
                    //Choose the type of vehicle operation
                    switch (option)
                    {
                        case 1:
                            myVehicle.Start();
                            Console.WriteLine("******You may enter 3 to stop the " + myVehicle.Name() + " " + vehicleTypeedit + "******");
                            break;

                        case 2:
                            myVehicle.Run();
                            Console.WriteLine("******You may enter 3 to stop the " + myVehicle.Name() + " " + vehicleTypeedit + "******");
                            break;

                        case 3:
                            myVehicle.Stop();
                            break;

                        default:
                            //Run the loop again when the number entered is not within the valid range
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.WriteLine("You have entered an invalid number. Please enter a value between 1 & 3");
                            Console.ResetColor();
                            break;
                    }
                }
            }
            Console.WriteLine("Program Exited!!!!!!");

        }
    }
}