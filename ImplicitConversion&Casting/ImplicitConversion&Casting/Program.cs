using System;

namespace ImplicitConversionAndCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            float x = 4.5f;

            double y = x;
            //here we have an implicit conversion, fload has 4bytes and double has 8bytes, float fits inside double, so it's converted

            Console.WriteLine(y);

            double a = 4.5;

            //float b = a;
            //This is not possible, double does not fit inside float, so we ned to cast it
            float b = (float)a;

            Console.WriteLine(b);

            double c;
            int d;

            c = 5.1;
            d = (int)c;
            Console.WriteLine($"C: {c}, D: {d}");

            int e = 5;
            int f = 2;

            double result = (double) e / f;
            Console.WriteLine(result);
        }
    }
}
