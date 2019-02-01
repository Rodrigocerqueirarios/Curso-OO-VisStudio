using System;
using System.Globalization;

namespace Exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Decimal glicose;

            Console.Write("Digite o Valor da medição de Glicose: ");
            glicose = decimal.Parse(Console.ReadLine().ToString(), CultureInfo.InvariantCulture);

            if (glicose > 140)
            {
                Console.WriteLine("Diabetes!");
                Console.ReadLine();
            }
            else if (glicose > 100 && glicose <= 140)
            {
                Console.WriteLine("Elevado!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Normal!");
                Console.ReadLine();
            }
        }
    }
}
