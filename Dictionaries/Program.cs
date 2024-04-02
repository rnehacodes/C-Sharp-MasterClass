namespace Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Intializing my first dictionary
             * Dictionary consists of a key-value pair
             * 
             * class System.Collections.Generic.Dictionary<TKey, TValue> where TKey : notnull
             * Represents a collection of keys and values.
            */

            //Part 1 - Intializing basic Dictinoary
            Dictionary<char, string> testDictionary = new Dictionary<char, string>()
            {
                {'a', "apple" },
                {'b', "blueberry" },
                {'c', "Chikoo" }
            };

            foreach (var fruits in testDictionary.ToArray())
            {
                Console.WriteLine(fruits);
            }

            foreach (var fruits in testDictionary.Values)
            {
                Console.WriteLine(fruits);
            }

            foreach (var fruits in testDictionary.Keys)
            {
                Console.WriteLine(fruits);
            }

            object[] dictionaryArray = testDictionary.Values.ToArray();

            foreach (object element in dictionaryArray)
            {
                Console.WriteLine(element);
            }

            Dictionary<int, String> listOfEmployees = new Dictionary<int, String>();

            listOfEmployees.Add(1, "John");
            listOfEmployees.Add(2, "jacob");
            listOfEmployees.Add(3, "anna");

            foreach (var employee in listOfEmployees)
            {
                Console.WriteLine(employee);
            }

            Employee[] employeesList = new Employee[]
            {
                new Employee("CEO", "Brutus", 59, 90),
                new Employee("Software Engineer", "Neha", 23, 50),
                new Employee("CFO", "Caesar", 40, 70),
                new Employee("CA", "John", 35, 60),
                new Employee("Accountant", "Maccon", 27, 30),
                new Employee("HR", "Dino", 30, 90)
            };

            Dictionary<string, Employee> employeeDictionary = new Dictionary<string, Employee>();

            foreach(Employee employee in employeesList)
            {
                employeeDictionary.Add(employee.Role, employee);
            }

            foreach (var employeeCard in employeeDictionary)
            {
                Console.WriteLine(employeeCard);
            }

            string role = "CEO";
            if (employeeDictionary.ContainsKey(role))
            {
                Console.WriteLine($"\nThe salary of {role} is {employeeDictionary[role].Salary}");
            }
            else
            {
                Console.WriteLine("No employee found with {0} key.", role);
            }

            Employee employeeResult = null;
            if (employeeDictionary.TryGetValue(role, out employeeResult))
            {
                Console.WriteLine(employeeResult);
            }
            else
            {
                Console.WriteLine("This key does not exist.");
            }

            Console.WriteLine("\n~~~~~~~~~~~~~~~~~~Key Value Pair~~~~~~~~~~~~~~~~~~");
            for (int i = 0; i < employeeDictionary.Count; i++)
            {
                KeyValuePair<string, Employee> employeeKeyValue = employeeDictionary.ElementAt(i);

                Console.WriteLine(i + " " + employeeKeyValue.Key + "\n" + employeeKeyValue.Value + "\n");
            }

            Console.WriteLine("\n~~~~~~~~~~~~~~~~~~Editing & Removing Entries from Dictionary~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Enter the key of the employeeDictionary or the \"Role\" of the employee you want to edit/update:");
            string updateRole = Console.ReadLine();
            if(employeeDictionary.TryGetValue(updateRole, out employeeResult))
            {
                //The updateRole exists in the employeeDictionary
                updateDictionary(updateRole, employeeDictionary);
            }
        }

        public static void printEmployeeDetails(string key, Dictionary<string, Employee> employeeDictionary)
        {
            Console.WriteLine("\nEmployee's current details: \n{0}\n", employeeDictionary[key]);
        }

        public static void updateDictionary(string key, Dictionary<string, Employee> employeeDictionary)
        {
            int num = -1;
            Console.WriteLine("\nEmployee's current details: \n{0}\n", employeeDictionary[key]);
            while (num != 0)
            {
                Console.WriteLine("What detail you'd like to update?\nEnter 1 for Role, 2 for Name, 3 for Age, 4 for Rate, 5 for Salary updation respectively.\nOr Enter 0 to exit the employee update process.");
                Validations.integerValidation(Console.ReadLine(), out num);

                switch (num)
                {
                    case 0:
                        Console.WriteLine("Employee updation process ended.");
                        return;
                        break;
                    case 1:
                        //Check if the entered role already exists in the dictionary or not
                        string newRole = "";
                        while(true)
                        {
                            Console.WriteLine("Please enter a new role:");
                            newRole = Console.ReadLine();
                            bool roleExists = employeeDictionary.Values.Any(emp => String.Equals(emp.Role, newRole, StringComparison.OrdinalIgnoreCase));
                            if (roleExists)
                            {
                                Console.WriteLine("There is at least one employee with the role of " + newRole);
                            }
                            else
                            {
                                employeeDictionary[key].Role = newRole;
                                break;
                            }
                        }
                        break;
                    case 2:
                        // Check if the entered Age already exists in the dictionary or not
                        string newName = "";
                        while (true)
                        {
                            Console.WriteLine("Please enter a new name:");
                            newName = Console.ReadLine();
                            bool nameExists = employeeDictionary.Values.Any(emp => String.Equals(emp.Name, newName, StringComparison.OrdinalIgnoreCase));
                            if (nameExists)
                            {
                                Console.WriteLine("There is at least one employee with the name " + newName);
                            }
                            else
                            {
                                employeeDictionary[key].Name = newName;
                                break;
                            }
                        }
                        break;
                    case 3:
                        //Ask for new age
                        Console.WriteLine("Please enter a new age:");
                        int newAge = 0;
                        Validations.integerValidation(Console.ReadLine(), out newAge);
                        employeeDictionary[key].Age = newAge;
                        break;
                    case 4:
                        //Ask for new rate
                        Console.WriteLine("Please enter a new rate:");
                        int newRate = 0;
                        Validations.integerValidation(Console.ReadLine(), out newRate);
                        employeeDictionary[key].Rate = newRate;
                        break;
                    case 5:
                        //Ask for new salary
                        Console.WriteLine("Please enter a new salary:");
                        int newSalary = 0;
                        Validations.integerValidation(Console.ReadLine(), out newSalary);
                        employeeDictionary[key].Salary = newSalary;
                        break;
                }
                //Print the updated details of employee
                Console.WriteLine("\nEmployee's UPDATED details: \n{0}\n", employeeDictionary[key]);
            }
        }
    }
}