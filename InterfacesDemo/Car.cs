using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    internal class Car : Vehicle, IDestroyable
    {
        public Car()
        {
            Color = "Golden";
            Speed = 100f;
        }
        public Car(float speed, string color) : base(speed, color)
        {
            Color = color;
            Speed = speed;
            DestructionSound = "CarExplosionSound.mp3";
            DestroyablesNearby = new List<IDestroyable>();
        }
        public string DestructionSound { get; set; }
        public List<IDestroyable> DestroyablesNearby { get; set; }
        public void Destroy()
        {
            Console.WriteLine("Playing Dectruction sound {0}", DestructionSound);
            Console.WriteLine("Create Fire");

            foreach (IDestroyable destroyable in DestroyablesNearby)
            {
                destroyable.Destroy();
            }
        }
    }
}
