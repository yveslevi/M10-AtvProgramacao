using Microsoft.VisualBasic;
using System;

namespace Temperatura
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Working!");
        }
    }

    public static class ConversorTemperatura
    {
        public static double FahrenheitParaCelsius(double temperatura)
            => Math.Round((temperatura - 32) / 1.8, 2);
    }
}
