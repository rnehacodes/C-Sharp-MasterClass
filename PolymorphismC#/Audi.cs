using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismC_
{
    internal class Audi : Car
    {
        private string Brand = "Audi";
        string Model { get; set; }
        public Audi(string model, int hp, string color) : base(hp, color)
        {
            this.Model = model;
        }
        public override void ShowDetails()
        {
            Console.WriteLine($"Audi Model {Model} has HP: {HP}, Color: {Color}");
        }
        public override void Repair()
        {
            Console.WriteLine($"Audi Model {Model} has been repaired!");
        }
    }
}
