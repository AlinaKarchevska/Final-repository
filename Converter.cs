using System;

namespace Converter_USD
{
    class Program
    {
        static void Main(string[] args)
        {
            double UsdToRub = 66.51;
            double UsdToUah = 27.22;
            double USD;

            Console.WriteLine("Введите суму в USD");

            USD = double.Parse(Console.ReadLine());

            Console.WriteLine($"{USD} дол в руб {USD * UsdToRub}");
            Console.WriteLine(USD + " дол в руб " + USD * UsdToRub);
            Console.WriteLine(USD + " дол в грн " + USD * UsdToUah);
        }
    }
}
