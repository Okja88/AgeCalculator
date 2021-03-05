using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add(1, 2); //data in brackets are arguments/parameters
            //Add(333, 222);
            //Add(double.Parse("2"), 2);

            Console.WriteLine("Please enter the first number:");
            string number1 = Console.ReadLine();

            Console.WriteLine("Please enter the second number:");
            string number2 = Console.ReadLine();

            Add(double.Parse(number1), double.Parse(number2)); //add (1100,123130);
        }
        public static void Add(double a, double b) //doesnt return anything, hence put void, functions r to be Added, there are two parameters
        {
            Console.WriteLine($"The sum of {a} and {b} is {a + b}");
                
            
        }
    }
}
