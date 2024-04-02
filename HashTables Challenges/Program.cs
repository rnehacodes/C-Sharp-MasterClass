using System.Collections;

namespace HashTables_Challenges
{
    //Challenge:
    /*
     Write a program that will iterate through each element of the students array and insert them into a hastable.
    If a student with the same ID already exists in the hashtable skip it and display the following error:
    "Sorry, A student with the same ID already Exists".
    Hint: Use the method ContainsKey() to check whether a student with the same ID already exists.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[5];
            students[0] = new Student(1, "Denis", 88);
            students[1] = new Student(2, "Olaf", 97);
            students[2] = new Student(6, "Ragner", 65);
            students[3] = new Student(1, "Luise", 73);
            students[4] = new Student(4, "Levi", 58);

            Hashtable hashtable = new Hashtable();
            Hashtable studentsTable = new Hashtable(); 

            for(int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("Student Id: " + students[i].Id + " || Student Name: " + students[i].Name + " || Student GPA: " + students[i].GPA);
                if (!(studentsTable.ContainsKey(students[i].Id)))
                {
                    studentsTable.Add(students[i].Id, students[i]);
                    Console.WriteLine("Student successfully added to the students table");
                }
                else
                {
                    Console.WriteLine("Sorry, A student with the same ID already Exists.");
                }
            }
        }
    }
}
