using System;

struct Student
{
    public string StudentNumber;
    public string Name;
    public string Program;
    public int YearLevel;
}

class Program
{
    static void Main()
    {
        Student[] students = new Student[10];
        int studentCount = 0;
        int choice = 0;

        while (choice != 6)
        {
            Console.WriteLine("========================================");
            Console.WriteLine("STUDENT RECORD MANAGEMENT");
            Console.WriteLine("========================================");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Display All Students");
            Console.WriteLine("3. Search Student");
            Console.WriteLine("4. Update Student");
            Console.WriteLine("5. Delete Student");
            Console.WriteLine("6. Exit");
            Console.Write("Enter choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                if (studentCount >= 10)
                {
                    Console.WriteLine("Cannot add more students. Maximum of 10 reached.\n");
                }
                else
                {
                    Console.Write("Enter Student Number: ");
                    students[studentCount].StudentNumber = Console.ReadLine();
                    Console.Write("Enter Name: ");
                    students[studentCount].Name = Console.ReadLine();
                    Console.Write("Enter Program: ");
                    students[studentCount].Program = Console.ReadLine();
                    Console.Write("Enter Year Level: ");
                    students[studentCount].YearLevel = Convert.ToInt32(Console.ReadLine());
                    studentCount++;
                    Console.WriteLine("Student added successfully!\n");
                }
            }
            else if (choice == 2)
            {
                Console.WriteLine("========================================");
                Console.WriteLine("STUDENT RECORDS");
                Console.WriteLine("========================================");
                for (int i = 0; i < studentCount; i++)
                {
                    Console.WriteLine("Student Number: " + students[i].StudentNumber);
                    Console.WriteLine("Name: " + students[i].Name);
                    Console.WriteLine("Program: " + students[i].Program);
                    Console.WriteLine("Year Level: " + students[i].YearLevel);
                }
                Console.WriteLine();
            }
            else if (choice == 3)
            {
                Console.Write("Enter Student Number: ");
                string num = Console.ReadLine();
                int index = -1;
                for (int i = 0; i < studentCount; i++)
                {
                    if (students[i].StudentNumber == num) index = i;
                }
                if (index == -1)
                {
                    Console.WriteLine("Student not found.\n");
                }
                else
                {
                    Console.WriteLine("Student Number: " + students[index].StudentNumber);
                    Console.WriteLine("Name: " + students[index].Name);
                    Console.WriteLine("Program: " + students[index].Program);
                    Console.WriteLine("Year Level: " + students[index].YearLevel);
                    Console.WriteLine();
                }
            }
            else if (choice == 4)
            {
                Console.Write("Enter Student Number: ");
                string num = Console.ReadLine();
                int index = -1;
                for (int i = 0; i < studentCount; i++)
                {
                    if (students[i].StudentNumber == num) index = i;
                }
                if (index == -1)
                {
                    Console.WriteLine("Student not found.\n");
                }
                else
                {
                    Console.Write("Enter Name: ");
                    students[index].Name = Console.ReadLine();
                    Console.Write("Enter Program: ");
                    students[index].Program = Console.ReadLine();
                    Console.Write("Enter Year Level: ");
                    students[index].YearLevel = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Student updated successfully!\n");
                }
            }
            else if (choice == 5)
            {
                Console.Write("Enter Student Number: ");
                string num = Console.ReadLine();
                int index = -1;
                for (int i = 0; i < studentCount; i++)
                {
                    if (students[i].StudentNumber == num) index = i;
                }
                if (index == -1)
                {
                    Console.WriteLine("Student not found.\n");
                }
                else
                {
                    for (int i = index; i < studentCount - 1; i++)
                    {
                        students[i] = students[i + 1];
                    }
                    studentCount--;
                    Console.WriteLine("Student deleted successfully!\n");
                }
            }
            else if (choice == 6)
            {
                Console.WriteLine("Program exited.");
            }
        }
    }
}