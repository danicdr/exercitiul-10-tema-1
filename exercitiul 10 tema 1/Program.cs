using System;

namespace MyFirstProgram2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti un numar:");
            int n = int.Parse(Console.ReadLine());
            int cifra = 0;
            int suma = 0;

            while (n != 0)
            {
                cifra = n % 10;
                suma = cifra + suma;
                n = n /= 10;

            }
            Console.Write(suma);
            Console.ReadLine();



        }
    }
}