using System;

namespace _05._Temperature_Conversion
{
    class Program
    {
        static void Main( string [ ] args )
        {
            double farenghait = double.Parse(Console.ReadLine());
            double celcius = FarenghaitToCelcius(farenghait);
            Console.WriteLine($"{celcius:f2}");

        }

        private static double FarenghaitToCelcius(double inputTemp)
        {
            return (inputTemp - 32) * 5 / 9;
        }
    }
}
