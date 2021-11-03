using System;
using System.Collections.Generic;
using System.Text;

namespace Calculations
{
    public class Calculation
    {
        public static double Addition(double number1, double number2)
        {
            return (number1 + number2);
        }
        public static double Subtraction(double number1, double number2)
        {
            return (number1 - number2);
        }
        public static double Multiplication(double number1, double number2)
        {
            return (number1 * number2);
        }
        public static double Division(double number1, double number2)
        {
            return (number1 / number2);
        }
        public static bool IsEvenNumber(int number)
        {
            return number % 2 == 0;
        }
    }
}
