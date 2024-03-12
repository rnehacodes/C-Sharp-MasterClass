using System.Collections;
using System.Collections.Generic;

namespace HashTables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable studentsTable = new Hashtable();
            List<Student> students = new List<Student>();

            string choice = "Y";
            while (choice == "Y")
            {
                //Ask the user to enter student Id
                Console.WriteLine("Enter the Student Id: ");
                int id = 0;
                bool isValidId = false;
                while(!isValidId)
                {
                    string idInput = Console.ReadLine(); 
                    try
                    {
                        id = int.Parse(idInput);
                        isValidId = true;
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("Oops! You've entered an invalid input. Please enter a valid number");
                    }
                }

                //Ask the user to enter student name
                Console.WriteLine("Enter the name of Student Id {0}: ", id);
                string name = Console.ReadLine();

                //Ask the user to enter student gender
                Console.WriteLine("Enter the Gender of {0}: ", name);
                string gender = Console.ReadLine();

                //Ask the user to enter student GPA score
                Console.WriteLine("Enter the GPA score of {0}: ", name);
                float score = 0;
                bool isValidScore = false;
                while (!isValidScore)
                {
                    string scoreInput = Console.ReadLine();
                    try
                    {
                        score = float.Parse(scoreInput);
                        isValidScore = true;
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("Oops! You've entered an invalid input. Please enter a valid score");
                    }
                }

                Student student = new Student(id, name, gender, score);
                studentsTable.Add(id, student);

                //Ask the user if further students need to be added or not
                Console.WriteLine("Do you want to add further students?\nEnter \"Y\" for yes and \"N\" for No.");
                choice = Console.ReadLine();
                while(!(choice == "Y" || choice == "N"))
                {
                    Console.WriteLine("Oops! You've entered an invalid input. Please enter either \"Y\" for Yes or \"N\" for No.");
                    choice = Console.ReadLine();
                }
            }

            Console.WriteLine("Student data entry process completed.\nWould you like to fetch student details for a particular student?(Enter \"Y\" for yes and \"N\" for No.)");
            choice = "Y";
            while(!(choice == "N"))
            {
                choice = Console.ReadLine();
                //Check for invalid inputs.
                    //If users enter invalid input -> Keep asking them for a valid input untill a valid input is received. 
                while (!(choice == "Y" || choice == "N"))
                {
                    Console.WriteLine("Oops! You've entered an invalid input. Please enter either \"Y\" for Yes or \"N\" for No.");
                    choice = Console.ReadLine();
                }
                //Ask the user to enter the student Id for which they want to fetch information.
                if (choice == "Y")
                {
                    Console.WriteLine("Enter the student id for which you want to fetch student details:");
                    int id = 0;
                    bool isValidId = false;
                    while (!isValidId)
                    {
                        string idInput = Console.ReadLine();
                        try
                        {
                            id = int.Parse(idInput);
                            isValidId = true;
                        }
                        catch (Exception)
                        {

                            Console.WriteLine("Oops! You've entered an invalid input. Please enter a valid student Id.");
                        }
                        if (!studentsTable.ContainsKey(id))
                        {
                            //If the studentsTable does not contain the entered key, ask the user to enter a valid student Id again.
                            Console.WriteLine("This student Id does not belong to any student. Please enter a valid student Id.");
                            isValidId = false;
                        }
                        else
                        {
                            Student student = (Student)studentsTable[id];
                            Console.WriteLine("Student Id: " + student.Id);
                            Console.WriteLine("Student Name: " + student.Name);
                            Console.WriteLine("Student Gender: " + student.Gender);
                            Console.WriteLine("Student GPA Score: " + student.Score);
                            isValidId = true;
                        }
                    }
                    
                }
                else
                {
                    break;
                }
                Console.WriteLine("Would you like to fetch student details for one more student?(Enter \"Y\" for yes and \"N\" for No.)");
            }

            //End of program
            Console.WriteLine("Program Exited!\nThankyou for using this program.");
        }
    }
}
