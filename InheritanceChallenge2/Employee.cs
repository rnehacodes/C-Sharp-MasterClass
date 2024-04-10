using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceChallenge2
{
    internal class Employee
    {
        public string Name {  get; set; }
        public string FirstName {  get; set; }
        public int Salary {  get; set; }

        //Constructor
        public Employee(string name, string firstName, int salary)
        {
            this.Name = name;
            this.FirstName = FirstName;
            this.Salary = salary;
        }

        public void Work()
        {
            Console.WriteLine("{0} has started working.", Name);
        }
        public void Pause()
        {
            Console.WriteLine("{0}'s work has been paused.", Name);
        }
    }
}
