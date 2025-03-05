using System;
using System.Globalization;

namespace Course { 
     class Program
    {
        static void Main(string[] args)
        {
            bool complete = false;
            char gender = 'f';
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648;
            float n5 = 4.5f;
            double n6 = 4.5;
            string name = "Nicolas";
            double saldo = 10.3412341;
            int age = 19;

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(complete);
            Console.WriteLine(gender);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(name);
            Console.WriteLine(int.MinValue);
            Console.WriteLine(saldo);
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4"));
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));

            Console.WriteLine("{0} is {1} years and has R${2:F2}", name, age, saldo);

            Console.WriteLine($"{name} is {age} years and ahs R${saldo:F2}");
        }
    }
}