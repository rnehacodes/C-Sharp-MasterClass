namespace Dictionaries
{
    class Employee
    {
        private float rate;
        private float salary; 
        public string Role { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public float Rate
        {
            get { return rate; }
            set
            {
                rate = value;
                salary = rate * 8 * 5 * 4 * 12;
            }
        }

        public float Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        //constructor
        public Employee(string role, string name, int age, float rate)
        {
            this.Role = role;
            this.Name = name;
            this.Age = age;
            this.Rate = rate;
        }

        //Method Overriding
        public override string ToString()
        {
            return $"Role: {Role}, Name: {Name}, Age: {Age}, Salary: {Salary}";
        }
    }
}
