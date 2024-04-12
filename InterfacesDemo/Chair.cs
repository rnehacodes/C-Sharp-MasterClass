using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    internal class Chair : Furniture, IDestroyable
    {
        public Chair()
        {
            Color = "Brown";
            Material = "Wood";
        }
        public Chair(string color, string material) : base(color, material)
        {
            Color = color;
            Material = material;
            DestructionSound = "ChairDestructionSound.mp3";
        }
        public string DestructionSound { get; set; }
        public void Destroy()
        {
            Console.WriteLine("Playing Chair Destruction sound {0}", DestructionSound);
            Console.WriteLine("Create little fire");
            Console.WriteLine("Spawning Chair Parts...");
        }
    }
}
