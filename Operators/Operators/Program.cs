using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 10;
            Console.WriteLine(a);

            a += 2;
            Console.WriteLine(a);

            a *= 3;
            Console.WriteLine(a);

            string s = "ABC";
            Console.WriteLine(s);

            s += "DEF";
            Console.WriteLine(s);

            int b = 10;
            b++;
            Console.WriteLine(b);

            int c = 10;
            int d = c++;
            int e = ++c;
            Console.WriteLine($"C: {c}, D: {d}, E: {e}");
        }
    }
}
