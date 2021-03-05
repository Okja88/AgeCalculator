using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Functions
    {
        //Fields
        private double _num1;
        private double _num2;
        public Functions(double a,double b) //constructor

        {
            _num1 = a;
            _num2 = b;
        }
        /// <summary>
        /// This function adds 2 double numbers.
        /// <para>It returns a string</para>
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public string Add(double a, double b) //doesnt return anything, hence put void, functions r to be Added, there are two parameters, no semicolon needed 
        {
            return $"The sum of {a} and {b} is {Math.Round(a + b, 2)}. \n And the values of _num1 and _num2 are {_num2} and {_num2}."; // rounding to 2 decima places
                                                                         //return Math.Round(a + b, 2); //returns a double data type, note the double in Add, instead of void
        }
        /// <summary>
        /// This function subtracts 2 double numbers.
        /// <para>It returns a string</para>
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public string Subtract(double a, double b) //doesnt return anything, hence put void, functions r to be Added, there are two parameters, no semicolon needed 
        {
            return $"The sum of {a} and {b} is {Math.Round(a - b, 2)}."; // rounding to 2 decima places
                                                                         //return Math.Round(a + b, 2); //returns a double data type, note the double in Add, instead of void

        }
    }
} // "Static" is removed from all Functions.cs but remained in program.cs. But for program.cs, "Static" remained in program.cs as there is a need for other classes to call this class in program



