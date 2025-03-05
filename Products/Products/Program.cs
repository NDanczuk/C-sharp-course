using System;
using System.Globalization;

namespace Products
{
    class Program
    {
        static void Main(string[] args)
        {
            string product1 = "Computer";
            string product2 = "Office table";

            byte age = 30;
            int code = 5290;
            char gender = 'M';

            double price1 = 2100.0;
            double price2 = 650.50;
            double value = 53.234567;

            Console.WriteLine("Products: ");
            Console.WriteLine($"{product1}, wich costs ${price1}");
            Console.WriteLine($"{product2}, wich costs ${price2}");

            Console.WriteLine($"Register: {age} years, code: {code} & gender: {gender}");

            Console.WriteLine($"Value with 8 decimal places: {value:F8}");
            Console.WriteLine($"Value with 3 decimal places: {value:F3}");
            Console.WriteLine($"Value with invariant culture: {value.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}
