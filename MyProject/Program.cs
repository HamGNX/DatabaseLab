// This is your fist application in C#
using System;
/* Don’t worry if you do not understand about namespaces
and classes yet, you will learn later about it */
namespace HelloWorld
{
    class Program
    {
        public static void GreetUser(string name)
        {
            Console.WriteLine($"Hello, {name}! Welcome!");
        }
        static void Main(string[] args)
        {

            // Hello World
            Console.WriteLine("Hello World!");

            // Exercise 1 P.13
            int myInt = 8;
            double myDouble = 7.89;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt));
            Console.WriteLine(Convert.ToDouble(myInt));
            Console.WriteLine(Convert.ToInt32(myDouble));
            Console.WriteLine(Convert.ToString(myBool));

            // Exercise 1 P.20 Write a C# program that checks if a given number is even or odd.
            Console.WriteLine("Enter a number: ");
            string input = Console.ReadLine();
            int num = Convert.ToInt32(input);
            if (num % 2 == 0)
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }

            // Exercise P.27 Create a C# method called GreetUser that takes a string parameter name and displays a greeting message with the user's name.

            string userName = "John";
            GreetUser("John");


        }
    }
}
// output: Hello World!