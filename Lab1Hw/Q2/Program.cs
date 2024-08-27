using System;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            // prompt the user 
            Console.WriteLine("Enter a positive integer: ");
            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);

            // while loop
            // int sumLoop = 0;
            // int i = 1;
            // while (i <= number)
            // {
            //     sumLoop += i;
            //     i++;
            // }
            // Console.WriteLine("The sum of numbers from 1 to " + number + " is: " + sumLoop);

            // for loop
            int sumLoop = 0;
            for (int j = 1; j <= number; j++)
            {
                sumLoop += j;
            }
            Console.WriteLine("The sum of numbers from 1 to " + number + " is: " + sumLoop);
        }
    }
}