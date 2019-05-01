using System;
using System.Globalization;

namespace URI1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int codFuncionario, horasTrabalhadas;
            double valorHora;

            codFuncionario = int.Parse(Console.ReadLine());
            horasTrabalhadas = int.Parse(Console.ReadLine());

            valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NUMBER = " + codFuncionario);
            Console.WriteLine("SALARY = U$ " + (horasTrabalhadas * valorHora).ToString("F2"), CultureInfo.InvariantCulture);

            Console.ReadLine();
        }
    }
}
