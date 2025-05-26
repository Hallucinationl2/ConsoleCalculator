using System;

class Calculator
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Въведете първо число: ");
            if (!double.TryParse(Console.ReadLine(), out double num1)) continue;

            Console.Write("Операция (+ - * /): ");
            string op = Console.ReadLine();

            Console.Write("Въведете второ число: ");
            if (!double.TryParse(Console.ReadLine(), out double num2)) continue;

            double result = 0;
            switch (op)
            {
                case "+": result = num1 + num2; break;
                case "-": result = num1 - num2; break;
                case "*": result = num1 * num2; break;
                case "/": result = num2 != 0 ? num1 / num2 : double.NaN; break;
                default: Console.WriteLine("Невалидна операция"); continue;
            }

            Console.WriteLine($"Резултат: {result}\n");
        }
    }
}