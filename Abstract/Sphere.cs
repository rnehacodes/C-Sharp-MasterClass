using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class Sphere : Shape
    {
        public Sphere(string name, int radius) : base(name)
        {
            Radius = radius;
        }

        public int Radius { get; set; }
        public override int Volume()
        {
            int volume = (4 / 3) * (int)Math.PI * (int)Math.Pow(Radius, 3);
            return volume;
        }
        public override void GetInfo()
        {
            Console.WriteLine("The spehere has a a radius {0} & volume {1}", Radius, Volume());
        }
    }
}
