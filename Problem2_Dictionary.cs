using System;
using System.Collections.Generic;

struct DictionaryStudent
{
    public string StudentNumber;
    public string Name;
    public string Program;
    public int YearLevel;
}

class Problem2
{
    static void Main()
    {
        Dictionary<string, Student> studentDictionary = new Dictionary<string, Student>();
        int choice = 0;

        while (choice != 4)
        {
            Console.WriteLine("========================================");
            Console.WriteLine("STUDENT LOOKUP USING DICTIONARY");
            Console.WriteLine("========================================");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Search Student");
            Console.WriteLine("3. Display All Students");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("Enter Student Number: ");
                string studentNumber = Console.ReadLine();

                if (studentDictionary.ContainsKey(studentNumber))
                {
                    Console.WriteLine("A student with that Student Number already exists.\n");
                }
                else
                {
                    Student newStudent = new Student();
                    newStudent.StudentNumber = studentNumber;
                    Console.Write("Enter Name: ");
                    newStudent.Name = Console.ReadLine();
                    Console.Write("Enter Program: ");
                    newStudent.Program = Console.ReadLine();
                    Console.Write("Enter Year Level: ");
                    newStudent.YearLevel = Convert.ToInt32(Console.ReadLine());

                    studentDictionary.Add(studentNumber, newStudent);
                    Console.WriteLine("Student added successfully!\n");
                }
            }
            else if (choice == 2)
            {
                Console.Write("Enter Student Number to search: ");
                string studentNumber = Console.ReadLine();

                if (studentDictionary.ContainsKey(studentNumber))
                {
                    Student s = studentDictionary[studentNumber];
                    Console.WriteLine("Student Found!");
                    Console.WriteLine("Student Number: " + s.StudentNumber);
                    Console.WriteLine("Name: " + s.Name);
                    Console.WriteLine("Program: " + s.Program);
                    Console.WriteLine("Year Level: " + s.YearLevel);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Student not found.\n");
                }
            }
            else if (choice == 3)
            {
                Console.WriteLine("========================================");
                Console.WriteLine("STUDENT RECORDS");
                Console.WriteLine("========================================");
                foreach (KeyValuePair<string, Student> entry in studentDictionary)
                {
                    Student s = entry.Value;
                    Console.WriteLine("Student Number: " + s.StudentNumber);
                    Console.WriteLine("Name: " + s.Name);
                    Console.WriteLine("Program: " + s.Program);
                    Console.WriteLine("Year Level: " + s.YearLevel);
                }
                Console.WriteLine();
            }
            else if (choice == 4)
            {
                Console.WriteLine("Program exited.");
            }
        }
    }
}
