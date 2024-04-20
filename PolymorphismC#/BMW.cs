using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismC_
{
    internal class BMW : Car
    {
        private string Brand = "BMW";
        string Model { get; set; }
        public BMW(string model, int hp, string color) : base(hp, color)
        {
            this.Model = model;
        }
        public new void ShowDetails()
        {
            Console.WriteLine($"BMW Model {Model} has HP: {HP}, Color: {Color}");
        }
        public override void Repair()
        {
            Console.WriteLine($"BMW Model {Model} has been repaired!");
        }
    }
}
