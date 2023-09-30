using System.Threading.Channels;
using System.Globalization;
using System.Numerics;
using System;
using System.ComponentModel.Design;
internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            double firstValue, secondValue;
            double action;
            try
            {
                Console.WriteLine("Введите число 1");
                firstValue = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите число 2");
                secondValue = double.Parse(Console.ReadLine());
                Console.WriteLine("Выберите действие '+' '-' '/' '*' ");

            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка!Введите коректное число.");
                Console.ReadLine();
                continue;
            }
            string result;
            result = Console.ReadLine();
            switch (result)
            {
                default:
                    Console.WriteLine("Неизвестное действие!");
                    break;
                case "+":
                    Console.WriteLine("Сумма чисел = " + (firstValue + secondValue));
                    break;
                case "-":
                    Console.WriteLine("Разность чисел = " + (firstValue - secondValue));
                    break;
                case "*":
                    Console.WriteLine("Произведение чисел = " + firstValue * secondValue);
                    break;
                case "/":
                    if (secondValue == 0)
                    {
                        Console.WriteLine("Ошибка.Данное действие сделать невозможно!");
                    }
                    else
                    {
                        Console.WriteLine("Частное чисел = " + firstValue / secondValue);
                    }
                    break;
            }
            Console.ReadLine();
            Console.Clear();
        }
    }
}
