using System;

namespace URI1019___conversaoTempo
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempo, horas, minutos, segundos, resto;

            tempo = int.Parse(Console.ReadLine());

            horas = tempo/ 3600;
            resto = tempo % 3600;

            minutos = resto / 60;
            segundos = resto % 60;

            Console.WriteLine(horas + ":" + minutos + ":" + segundos);
            Console.ReadLine();
        }
    }
}