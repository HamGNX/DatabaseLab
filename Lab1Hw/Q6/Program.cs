using System;

namespace Q6
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class StudentDBMS
    {
        private Student[] students;
        private int counter;

        public StudentDBMS(int size)
        {
            students = new Student[size];
            counter = 0;
        }

        public void AddStudent(string name, int age)
        {
            if (counter < students.Length)
            {
                students[counter] = new Student { Id = counter + 1, Name = name, Age = age };
                counter++;
                Console.WriteLine("Student added successfully!");
            }
            else
            {
                Console.WriteLine("Database is full. Cannot add more students.");
            }
        }

        public void DisplayAllStudents()
        {
            Console.WriteLine("----- List of Students -----");
            for (int i = 0; i < counter; i++)
            {
                Console.WriteLine($"ID: {students[i].Id}, Name: {students[i].Name}, Age: {students[i].Age}");
            }
        }

        public void SearchStudentById(int id)
        {
            for (int i = 0; i < counter; i++)
            {
                if (students[i].Id == id)
                {
                    Console.WriteLine($"ID: {students[i].Id}, Name: {students[i].Name}, Age: {students[i].Age}");
                    return;
                }
            }
            Console.WriteLine("Student not found.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            StudentDBMS dbms = new StudentDBMS(100); // Assuming a maximum of 100 students
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("===== Student Management System =====");
                Console.WriteLine("1. Add a new student");
                Console.WriteLine("2. Display all students");
                Console.WriteLine("3. Search student by ID");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter student's name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter student's age: ");
                        int age = Convert.ToInt32(Console.ReadLine());
                        dbms.AddStudent(name, age);
                        break;
                    case 2:
                        dbms.DisplayAllStudents();
                        break;
                    case 3:
                        Console.Write("Enter student ID to search: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        dbms.SearchStudentById(id);
                        break;
                    case 4:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}