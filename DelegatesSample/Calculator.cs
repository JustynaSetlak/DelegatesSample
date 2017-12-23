using System;

namespace DelegatesSample
{
    public class Calculator
    {
        public delegate int ArithmeticDelegate(int firstNumber, int seconNumber);

        public double Divide(double firstNumber, double secondNumber, Func<int> error)
        {
            if (secondNumber == 0)
            {
                return error();
            }
            return firstNumber / secondNumber;
        }

        public int Substract(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public double GetRadical(double number)
        {
            if (number < 0)
            {
                number = GetModulus(number);
            }

            return Math.Sqrt(number);

            double GetModulus(double negativeNumber)
            {
                return Math.Abs(negativeNumber);
            }
        }
    }
}