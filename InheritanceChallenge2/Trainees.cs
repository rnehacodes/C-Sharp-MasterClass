using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceChallenge2
{
    internal class Trainees : Employee
    {
        public int WorkingHours { get; set; }
        public int SchoolHours { get; set; }
        public Trainees (string name, string firstName, int salary, int workingHours, int schoolHours) : base(name, firstName, salary) 
        {
            this.WorkingHours = workingHours;
            this.SchoolHours = schoolHours;
        }
        public void Learn()
        {
            Console.WriteLine("Trainee {0} is learning right now", Name);
        }
        public override void Work()
        {
            Console.WriteLine("{0}(Trainee) is working. Although his/her working hours are {1} hrs", Name, WorkingHours);
        }
        public override string ToString()
        {
            return $"Name - {Name}, First Name - {FirstName}, Salary - {Salary}, Working Hours - {WorkingHours}, School Hours - {SchoolHours}";
        }
    }
}
