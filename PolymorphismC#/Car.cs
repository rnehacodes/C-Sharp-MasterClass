﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismC_
{
    internal class Car
    {
        public int HP { get; set; }
        public string Color { get; set; }
        
        protected CarInfo carIDInfo = new CarInfo();
        
        public void SetCarIDInfo(int idNum, string owner)
        {
            carIDInfo.Id = idNum;
            carIDInfo.Owner = owner;
        }

        public void GetCarIDInfo()
        {
            Console.WriteLine($"The car with id {carIDInfo.Id} is owned by {carIDInfo.Owner}");
        }

        public Car(int hP, string color)
        {
            this.HP = hP;
            this.Color = color;
        }
        public virtual void ShowDetails()
        {
            Console.WriteLine("Car's HP: " + HP + ", Color: " + Color);
        }
        public virtual void Repair()
        {
            Console.WriteLine("The car has been repaired!");
        }
    }
}
