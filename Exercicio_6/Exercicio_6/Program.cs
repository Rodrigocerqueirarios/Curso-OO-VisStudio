using System;
using System.Globalization;

namespace Exercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, soma;
            soma = 0;

            Console.Write("Digite o 1° numero: ");
            num1 = int.Parse(Console.ReadLine().ToString(), CultureInfo.InvariantCulture);

            Console.Write("Digite o 2° numero: ");
            num2 = int.Parse(Console.ReadLine().ToString(), CultureInfo.InvariantCulture);

            for (int i = num1; i <= num2; i++)
            {
                if (i % 2 != 0)
                {
                    soma = soma + i;
                }
            }

            Console.WriteLine("O valor final da Operação é: " + soma.ToString());
            Console.ReadLine();
        }
    }
}
