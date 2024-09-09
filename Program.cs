using System;

namespace BincomDevAssessment
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Task 1:
            //Declaring and initializing variables

            string name = "John Doe";
            int age = 25;
            bool isAdmin = true;

            Console.WriteLine("Task 1: ");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Is Admin: {isAdmin}");
            Console.WriteLine();


            //Task 2:
            //Algorithm to check if number is even or odd

            Console.WriteLine("Task 2:");

            int input = int.Parse(Console.ReadLine());


            if (input == 0 || input % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
            Console.WriteLine();


            //Task 3:
            //A program that prints out the numbers 1 to 10 using a for loop

            int result = 0;

            Console.WriteLine("Task 3:");

            for (int i = 1; i <= 10; i++)
            {
                result = i;
                Console.WriteLine(result);
            }

            Console.WriteLine();


            //Task 4:
            //Declare, initialize and print the sum of the values of an array

            int[] array = { 2, 4, 6, 8, 10 };
            int sum = 0;

            Console.WriteLine("Task 4:");

            foreach (var number in array)
            {
                Console.WriteLine(number);
                sum += number;
            }
            Console.WriteLine($"Sum of all elements in the array: {sum}");

            Console.WriteLine();


            //Calling Task 5's method

            Console.WriteLine("Task 5:");

            Greet("Alice");

            Console.ReadLine();
        }

        //Task 5:
        //A method that takes a string parameter and prints out a personalized greeting message.

        public static void Greet(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}