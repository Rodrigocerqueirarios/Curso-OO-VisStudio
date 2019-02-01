using System;
using System.Globalization;

namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int LargF, LargP, AlturaF, AlturaP;

            Console.Write("Digite a Largura e Altura da Foto: ");
            string [] vet = Console.ReadLine().Split(' ');
            LargF = int.Parse(vet[0]);
            AlturaF = int.Parse(vet[1]);

            Console.Write("Digite a Largura e Altura do Porta Retratos: ");
            vet = Console.ReadLine().Split(' ');
            LargP = int.Parse(vet[0]);
            AlturaP = int.Parse(vet[1]);

            if ((LargF <= LargP && AlturaF <= AlturaP) || (AlturaF <= LargP && LargF <= AlturaP))
            {
                Console.WriteLine("Sim!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Não!");
                Console.ReadLine();
            }
        }
    }
}
