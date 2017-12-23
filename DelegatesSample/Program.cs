using System;

namespace DelegatesSample
{
    class Program
    {
        delegate int ArithmeticDelegate(int firstNumber, int seconNumber);

        static void Main(string[] args)
        {
            var calculator = new Calculator();
           
            var divideResult = calculator.Divide(4, 0, () =>
            {
                Console.WriteLine("An error occured. Can't divide by 0"); return 0;
            });
            Console.WriteLine($" Divide: {divideResult}");

            var operation = new ArithmeticDelegate(calculator.Add);
            var resultOfOperation = operation(1, 3);
            Console.WriteLine($"Add: {resultOfOperation}");

            var sqrt = calculator.GetRadical(-16);
            Console.WriteLine($"Radical: {sqrt}");

            Console.ReadKey();
        }
    }
}
