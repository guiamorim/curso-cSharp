using System;
using System.Globalization;

namespace URI1015___sqrt_e_pow
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, y1, x2, y2, distancia;

            string[] vet = Console.ReadLine().Split(' ');
            string[] vet2 = Console.ReadLine().Split(' ');

            x1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            y1 = double.Parse(vet[1], CultureInfo.InvariantCulture);
            x2 = double.Parse(vet2[0], CultureInfo.InvariantCulture);
            y2 = double.Parse(vet2[1], CultureInfo.InvariantCulture);

            //Função matemática que calcula a raiz quadrada de um valor - precisa ter um valor double (ponto flutuante)
            distancia = Math.Sqrt(Math.Pow((x2 - x1), 2.0) + Math.Pow((y2 - y1), 2.0));
            
            Console.WriteLine(distancia.ToString("F4"), CultureInfo.InvariantCulture);

            Console.ReadLine();
                       
        }
    }
}
