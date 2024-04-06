using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingInheritance
{
    internal class Radio : ElectricalDevice
    {
        public Radio(bool isOn, string brand) : base(isOn, brand)
        {
            //
        }

        //listen to the radio
        public void ListenToTheRadio()
        {
            if(IsOn)
            {
                Console.WriteLine("Listening to the Radio!!!");
            }
            else
            {
                Console.WriteLine("Radio is turned OFF. Switch it ON to listen to the music.");
            }
        }
    }
}
