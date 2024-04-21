using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismC_
{
    internal class M3 : Audi
    {
        public M3(string model, int hp, string color) : base(model, hp, color) 
        {
            //
        }

        //Cannot be inherited due to sealed keyword
        //public override void ShowDetails()
        //{
        //    Console.WriteLine($"Audi Model {Model} has HP: {HP}, Color: {Color}");
        //}
    }
}
