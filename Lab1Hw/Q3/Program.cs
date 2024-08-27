using System;

namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            // ask user
            Console.WriteLine("Enter the number of elements in the array: ");
            int n = Convert.ToInt32(Console.ReadLine());

            // array
            int[] array = new int[n];

            // get elements 
            Console.WriteLine("Enter " + n + " integer elements:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Element " + (i + 1) + ": ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Calculate sum, max, min, and average
            int sum = 0;
            int max = array[0];
            int min = array[0];
            for (int i = 0; i < n; i++)
            {
                sum += array[i];
                if (array[i] > max) max = array[i];
                if (array[i] < min) min = array[i];
            }
            double average = (double)sum / n;

            // Print results
            Console.WriteLine("Sum of elements: " + sum);
            Console.WriteLine("Maximum element: " + max);
            Console.WriteLine("Minimum element: " + min);
            Console.WriteLine("Average of elements: " + average);
        }
    }
}