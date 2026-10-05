using System;
using System.Collections.Generic;

struct StudentRequest
{
    public string StudentNumber;
    public string StudentName;
    public string RequestType;
}

class Program
{
    static void Main()
    {
        Queue<StudentRequest> requestQueue = new Queue<StudentRequest>();
        int choice = 0;

        while (choice != 4)
        {
            Console.WriteLine("========================================");
            Console.WriteLine("STUDENT REQUEST QUEUE");
            Console.WriteLine("========================================");
            Console.WriteLine("1. Add Request");
            Console.WriteLine("2. View Pending Requests");
            Console.WriteLine("3. Process Request");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                StudentRequest newRequest = new StudentRequest();
                Console.Write("Enter Student Number: ");
                newRequest.StudentNumber = Console.ReadLine();
                Console.Write("Enter Student Name: ");
                newRequest.StudentName = Console.ReadLine();
                Console.Write("Enter Request Type: ");
                newRequest.RequestType = Console.ReadLine();

                requestQueue.Enqueue(newRequest);
                Console.WriteLine("Request added successfully!\n");
            }
            else if (choice == 2)
            {
                if (requestQueue.Count == 0)
                {
                    Console.WriteLine("No pending requests.\n");
                }
                else
                {
                    Console.WriteLine("REQUEST QUEUE");
                    int number = 1;
                    foreach (StudentRequest r in requestQueue)
                    {
                        Console.WriteLine(number + ". " + r.StudentName + " - " + r.RequestType);
                        number++;
                    }
                    Console.WriteLine();
                }
            }
            else if (choice == 3)
            {
                if (requestQueue.Count == 0)
                {
                    Console.WriteLine("No pending requests.\n");
                }
                else
                {
                    StudentRequest processed = requestQueue.Dequeue();
                    Console.WriteLine("Processing Request: " + processed.StudentName + " - " + processed.RequestType);
                    Console.WriteLine("Request processed successfully!\n");
                }
            }
            else if (choice == 4)
            {
                Console.WriteLine("Program exited.");
            }
        }
    }
}