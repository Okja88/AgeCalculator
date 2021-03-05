using System;

namespace AgeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(" Enter your name here: ");  
                string name = Console.ReadLine();

            Console.WriteLine(" Please enter your age: ");
            string age = Console.ReadLine();

            Console.WriteLine($"hello {name}! \nWelcome to C# Essential. \n Your age is {age}.");

            Console.WriteLine($"And your next age is {double.Parse(age) + 1}."); //convert age to integer by adding double.Parse(age), 
            //note age is bracketed. if parsed to int, might not work. hence parsed as double, works w decimal points
            
         }
    }
}
