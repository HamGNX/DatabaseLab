using System;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            // first number
            Console.WriteLine("Enter the first number: ");
            string input1 = Console.ReadLine();
            int number1 = Convert.ToInt32(input1);

            // second number
            Console.WriteLine("Enter the second number: ");
            string input2 = Console.ReadLine();
            int number2 = Convert.ToInt32(input2);

            // sum, difference, product, quotient
            int sum = number1 + number2;
            int difference = number1 - number2;
            int product = number1 * number2;
            double quotient = (double)number1 / number2;

            // print
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Difference: " + difference);
            Console.WriteLine("Product: " + product);
            Console.WriteLine("Quotient: " + quotient);
        }
    }
}