using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                double firstNum, secondNum, result;
                string switchNum;
                string str;

                NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
                {
                    NumberDecimalSeparator = ".",
                };

                try
                {
                    Console.Write("Введите первое число: ");

                    str = Console.ReadLine();

                    firstNum = Convert.ToDouble(str, numberFormatInfo);

                    Console.Write("Введите второе число: ");

                    str = Console.ReadLine();

                    secondNum = Convert.ToDouble(str, numberFormatInfo);
                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка ввода!");
                    Thread.Sleep(2000);
                    continue;                    
                }
                
                Console.WriteLine("Операции: | + | - | * | / | ");

                Console.Write("Выберете операцию: ");

                switchNum = Console.ReadLine();

                switch (switchNum)
                {
                    case "+":
                        result = firstNum + secondNum;
                        Console.WriteLine(firstNum + " + " + secondNum + " = " + result);
                        break;
                    case "-":
                        result = firstNum - secondNum;
                        Console.WriteLine(firstNum + " - " + secondNum + " = " + result);
                        break;
                    case "*":
                        result = firstNum * secondNum;
                        Console.WriteLine(firstNum + " * " + secondNum + " = " + result);
                        break;
                    case "/":
                        if (firstNum == 0 || secondNum == 0)
                        {
                            Console.WriteLine("Деление на 0!");
                        }
                        else
                        {
                            result = firstNum / secondNum;
                            Console.WriteLine(firstNum + " / " + secondNum + " = " + result);
                        }
                        break;
                    default:
                        Console.WriteLine("Такой операции нет!");
                        break;
                }
                Thread.Sleep(2000);
            }
        }
    }
}
