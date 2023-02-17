using System;
using System.Collections.Generic;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
}

class Program
{
    static List<Student> students = new List<Student>();

    static void Main(string[] args)
    {
        Console.WriteLine("Student Record Management System");

        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("\nSelect an option:");
            Console.WriteLine("1. Add student");
            Console.WriteLine("2. Search student");
            Console.WriteLine("3. Display all students");
            Console.WriteLine("4. Exit");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    AddStudent();
                    break;
                case "2":
                    SearchStudent();
                    break;
                case "3":
                    DisplayAllStudents();
                    break;
                case "4":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }

        Console.WriteLine("Goodbye!");
    }

    static void AddStudent()
    {
        Console.WriteLine("\nEnter student details:");

        Student student = new Student();

        Console.Write("ID: ");
        student.Id = int.Parse(Console.ReadLine());

        Console.Write("Name: ");
        student.Name = Console.ReadLine();

        Console.Write("Email: ");
        student.Email = Console.ReadLine();

        Console.Write("Phone Number: ");
        student.PhoneNumber = Console.ReadLine();

        students.Add(student);

        Console.WriteLine("Student added successfully.");
    }

    static void SearchStudent()
    {
        Console.Write("\nEnter student ID: ");
        int id = int.Parse(Console.ReadLine());

        Student student = students.Find(s => s.Id == id);
        if (student != null)
        {
            Console.WriteLine("\nStudent details:");
            Console.WriteLine("ID: {0}", student.Id);
            Console.WriteLine("Name: {0}", student.Name);
            Console.WriteLine("Email: {0}", student.Email);
            Console.WriteLine("Phone Number: {0}", student.PhoneNumber);
        }
        else
        {
            Console.WriteLine("Student not found.");
        }
    }

    static void DisplayAllStudents()
    {
        Console.WriteLine("\nAll students:");

        foreach (Student student in students)
        {
            Console.WriteLine("{0} - {1}", student.Id, student.Name);
        }
    }
}
