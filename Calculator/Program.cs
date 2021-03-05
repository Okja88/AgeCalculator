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

            string result = Add(double.Parse(number1), double.Parse(number2)); // these two lines 19 & 20 are alternative to line 22
                Console.WriteLine(result);

            //Console.WriteLine(Add(double.Parse(number1), double.Parse(number2))); // put in Console.WriteLine

            Functions myFunctions = new Functions(9,10); //instantiating a new functions called myfunctions, note the "new"
            Console.WriteLine(myFunctions.Add(2, 3));
            Console.WriteLine(myFunctions.Subtract(2, 4));

            Functions myFunctions2 = new Functions(11,12); //instantiating a new functions called myfunctions, note the "new"
            Console.WriteLine(myFunctions2.Add(5, 10));
            Console.WriteLine(myFunctions2.Subtract(4, 10));

        }/// <summary>
         /// This function adds 2 double numbers.
         /// <para>It returns a string</para>
         /// </summary>
         /// <param name="a"></param>
         /// <param name="b"></param>
         /// <returns></returns>
        public static string Add(double a, double b) //doesnt return anything, hence put void, functions r to be Added, there are two parameters, no semicolon needed 
        {
            return $"The sum of {a} and {b} is {Math.Round(a + b, 2)}."; // rounding to 2 decima places
            //return Math.Round(a + b, 2); //returns a double data type, note the double in Add, instead of void


        }
    }
}//string the reult as return, and string the Add(double a, double b) in line 24
