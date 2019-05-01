using System;
using System.Globalization; //Biblioteca para considerar pontuações no padrão inerncaional

namespace URI1012___Geometria
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, pi, triangulo, circulo, trapezio, quadrado, retangulo;

            //Leitura (entrada) de valores em uma mesma linha com o uso das posições de vetor
            //O programa faz a leitura dos dados em um conjunto (linha) ou vetor e considera a entrada destes dados como uma string
            //Em seguida considera o comando Split com a condição de em cada "espaço" separar para uma posição do vetor

            string[] vet = Console.ReadLine().Split(' ');

            //O double.Parse considera como valores de ponto flutuante os dados que serão armazenados nos vetores

            A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            C = double.Parse(vet[2], CultureInfo.InvariantCulture);
            pi = 3.14159;

            //Abaixo as formulas da área de cada uma das figuras geométricas

            //Triangulo é a base * altura / 2
            triangulo = (A * C) / 2;
            //Area do círculo é Pi * o valor do raio ao quadrado
            circulo = pi * (Math.Pow(C, 2));
            //Área do trapézio é o resultado da média das duas bases multiplicado pelo valor da altura
            trapezio = ((A + B) / 2) * C;
            //Área do quadrado equilátero é o valor de um dos lados elevado ao quadrado
            quadrado = Math.Pow(B, 2);
            //Área do retângulo é o produto do valor de dois lados
            retangulo = A * B;

            //Impressão na tela do resultado
            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3"), CultureInfo.InvariantCulture);
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3"), CultureInfo.InvariantCulture);
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3"), CultureInfo.InvariantCulture);
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3"), CultureInfo.InvariantCulture);
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3"), CultureInfo.InvariantCulture);

            Console.ReadLine();
        }
    }
}
