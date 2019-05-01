using System;
using System.Globalization;

namespace URI1011
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio, volumeEsfera, pi;

            pi = 3.14159;
            raio = double.Parse(Console.ReadLine());
            volumeEsfera = (4.0 / 3) * pi * (Math.Pow(raio, 3));

            Console.WriteLine("VOLUME = " + volumeEsfera.ToString("F3"), CultureInfo.InvariantCulture);

            Console.ReadLine();

        }
    }
}
