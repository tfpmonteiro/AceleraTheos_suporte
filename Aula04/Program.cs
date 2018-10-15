using System;
using System.Globalization;

namespace Aula04
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.Converter a temperatura em graus Fahrenheit para graus Celsius. (°C = (°F - 32) * 5/9)
            Console.WriteLine("Digite a temperatura em Fahrenheit para ser convertida em Celsus.");

            double tempF = Convert.ToDouble(Console.ReadLine());
            double tempC = (tempF - 32) * 5 / 9;

            Console.WriteLine($"{tempF.ToString("n2", new CultureInfo("en-us"))}°F equivale a {tempC.ToString("n2", new CultureInfo("en-us"))}°C");

            Console.ReadKey();

        }
    }
}
