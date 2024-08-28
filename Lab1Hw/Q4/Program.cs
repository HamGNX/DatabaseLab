using System;

namespace Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            // input number of students
            Console.WriteLine("Enter the number of students: ");
            int numberOfStudents = Convert.ToInt32(Console.ReadLine());

            // store scores
            int[] scores = new int[numberOfStudents];

            // get scores
            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.Write("Enter the score of student " + (i + 1) + ": ");
                scores[i] = Convert.ToInt32(Console.ReadLine());
            }

            // sum scores
            int sum = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                sum += scores[i];
            }

            // calculate average
            double average = (double)sum / scores.Length;
            Console.WriteLine("The class average is: " + average.ToString("F2"));
        }
    }
}