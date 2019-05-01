using System;

namespace URI1020___mod
{
    class Program
    {
        static void Main(string[] args)
        {
            double diaJeova, meses, anoHumano, dias, horasJeova, minutos, segundos;
            double rMeses, rDias, rHOras, rMinutos;

            anoHumano = double.Parse(Console.ReadLine());
            diaJeova = 0.001*anoHumano;
            horasJeova = diaJeova / 24;

            
            Console.WriteLine(anoHumano + " anos(s) do Ser Humano, são " + (diaJeova) + " dia(s) para Jeová");
            Console.WriteLine(anoHumano + " anos(s) do Ser Humano, são " + (horasJeova).ToString("F2") + " hora(s) para Jeová");

            Console.ReadLine();

        }
    }
}
