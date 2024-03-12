using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTables
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public float Score { get; set; }
        public Student(int Id, string Name, string Gender, float Score)
        {
            this.Id = Id;
            this.Name = Name;
            this.Gender = Gender;
            this.Score = Score;
        }
    }
}
