using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal abstract class Shape
    {
        public string Name { get; set; }
        public Shape(string name)
        {
            Name = name;
        }

        public virtual void GetInfo()
        {
            Console.WriteLine("Shape name is {0}", Name);
        }
        public abstract int Volume();
    }
}
