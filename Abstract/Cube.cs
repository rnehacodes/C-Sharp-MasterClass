using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class Cube : Shape
    {
        public int Length { get; set; }
        public Cube(int length, string name) : base(name)
        {
            Length = length;
        }
        public override int Volume()
        {
            return (int)Math.Pow(Length, 3);
        }
        public override void GetInfo()
        {
            //base.GetInfo();
            Console.WriteLine($"Cube name is {Name}");
        }
    }
}
