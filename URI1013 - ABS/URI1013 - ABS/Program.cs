using System;
using System.Globalization;

namespace URI1013___ABS
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, maiorAB, maiorABC;

            string[] vet = Console.ReadLine().Split(' ');

            a = int.Parse(vet[0], CultureInfo.InvariantCulture);
            b = int.Parse(vet[1], CultureInfo.InvariantCulture);
            c = int.Parse(vet[2], CultureInfo.InvariantCulture);

            //a variável maiorAB carrega a fórmula que compara qual o valor maior entre as variaveis (ou entrada de dados a e b)
            maiorAB = ((a + b) + Math.Abs(a - b)) / 2;
            //em seguida aplica-se a mesma fórmula, mas já entre o resultado encontrado na expressão anterior e o do 3º valor, o que foi atribuido na variável c
            maiorABC = ((maiorAB + c) + Math.Abs(maiorAB - c)) / 2;

            Console.WriteLine(maiorABC + " eh o maior");

            Console.ReadLine();
        }
    }
}
