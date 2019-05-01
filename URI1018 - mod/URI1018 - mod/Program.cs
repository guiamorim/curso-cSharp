using System;

namespace URI1018___mod
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exte exercício via a prática do operador mod.
            // Cálculo do menor número de notas possíveis no qual determinado valor pode ser decomposto. Consideradno o valor padrão as cédulas existentes.
            //(0 < N < 1000000)

            int N, nota100, nota50, nota20, nota10, nota5, nota2, nota1;
            int resto100, resto50, resto20, resto10, resto5, resto2;

            N = int.Parse(Console.ReadLine());

            //Após a entrada do valor, este irá ser factorado com base no valor das notas
            //Dividi-se o valor principal pela nota de maior valor
            //Em seguida, calcula o resto através da função % (mod)
            //Em seguida, usa-se este valor de resto gerado para dividir pelo valor correspondente a maior cédula seguinte, até que se finalize os tipos de cédulas.
            nota100 = N / 100;
            resto100 = N % 100;

            nota50 = resto100 / 50;
            resto50 = resto100 % 50;

            nota20 = resto50 / 20;
            resto20 = resto50 % 20;

            nota10 = resto20 / 10;
            resto10 = resto20 % 10;

            nota5 = resto10 / 5;
            resto5 = resto10 % 5;

            nota2 = resto5 / 2;
            resto2 = resto5 % 2;

            nota1 = resto2 / 1;
                                                  
            Console.WriteLine(N);
            Console.WriteLine(nota100 + " nota(s) de R$ 100,00");
            Console.WriteLine(nota50 + " nota(s) de R$ 50,00");
            Console.WriteLine(nota20 + " nota(s) de R$ 20,00");
            Console.WriteLine(nota10 + " nota(s) de R$ 10,00");
            Console.WriteLine(nota5 + " nota(s) de R$ 5,00");
            Console.WriteLine(nota2 + " nota(s) de R$ 2,00");
            Console.WriteLine(nota1 + " nota(s) de R$ 1,00");
            
            Console.ReadLine();

        }
    }
}
