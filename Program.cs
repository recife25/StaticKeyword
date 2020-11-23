//Felipe Ruiz
//Static Exercises
using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var celcius = TempConverter.FahrenheitToCelsius(68);
            var fahrenheit = TempConverter.CelsiusToFahrenheit(20);
            Console.WriteLine("After Conversions");
            Console.WriteLine($"celcius{celcius}");
            Console.WriteLine("");
            Console.WriteLine($"farenheit{fahrenheit}");
            
        }
    }
}
