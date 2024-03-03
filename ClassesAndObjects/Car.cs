using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    internal class VehicleEdit
    {
        private string vehicleName;
        public VehicleEdit(string name) {
            Console.WriteLine(name + " is created!");
            vehicleName = name;
        }
        public void Start()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine($"{vehicleName} has Started....");
            Console.ResetColor();
        }
        public void Run()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine($"{vehicleName} is Running....");
            Console.ResetColor();
        }
        public void Stop() 
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine($"{vehicleName} has Stopped!!!!!!");
            Console.ResetColor();
        }

        public string Name()
        {
            return vehicleName;
        }
    }
}
