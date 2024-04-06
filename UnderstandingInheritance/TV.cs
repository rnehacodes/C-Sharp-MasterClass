using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingInheritance
{
    //child class
    internal class TV : ElectricalDevice
    {
        //constructor
        public TV(bool isOn, string brand) : base(isOn, brand)
        {
            //
        }

        //listen to the TV
        public void WatchTheTV()
        {
            if (IsOn)
            {
                Console.WriteLine("Watching the TV!!!");
            }
            else
            {
                Console.WriteLine("TV is turned OFF. Switch it ON to watch it.");
            }
        }
    }
}
