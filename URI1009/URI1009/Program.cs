using System;
using System.Globalization;

namespace URI1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeVendedor;
            double salarioFixo, totalVendas;

            nomeVendedor = Console.ReadLine();
            salarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            totalVendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("TOTAL = R$ " + ((totalVendas * 15.0/100)+salarioFixo).ToString("F2"), CultureInfo.InvariantCulture);

            Console.ReadLine();
        }
    }
}
