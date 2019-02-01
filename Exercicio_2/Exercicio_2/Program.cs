using System;
using System.Globalization;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Decimal nota1, nota2, nota3, media;

            Console.Write("Digite a nota do 1° Trimestre: ");
            nota1 = decimal.Parse(Console.ReadLine());
            while (nota1.ToString(CultureInfo.InvariantCulture).Split('.')[1].Length != 2)
            {
                Console.WriteLine("Digite um valor com duas casas decimais!");
                Console.Write("Digite novamente a nota do 1° Trimestre: ");
                nota1 = decimal.Parse(Console.ReadLine());
            }
            Console.Write("Digite a nota do 2° Trimestre: ");
            nota2 = decimal.Parse(Console.ReadLine());
            while (nota2.ToString(CultureInfo.InvariantCulture).Split('.')[1].Length != 2)
            {
                Console.WriteLine("Digite um valor com duas casas decimais!");
                Console.Write("Digite novamente a nota do 2° Trimestre: ");
                nota2 = decimal.Parse(Console.ReadLine());
            }
            Console.Write("Digite a nota do 3° Trimestre: ");
            nota3 = decimal.Parse(Console.ReadLine());
            while (nota3.ToString(CultureInfo.InvariantCulture).Split('.')[1].Length != 2)
            {
                Console.WriteLine("Digite um valor com duas casas decimais!");
                Console.Write("Digite novamente a nota do 3° Trimestre: ");
                nota3 = decimal.Parse(Console.ReadLine());
            }

            media = (nota1 + nota2 + nota3);

            if (media < 60)
            {
                Console.WriteLine("A media das notas do Aluno foi de: " + media);
                Console.WriteLine("Dependência");
            }
            else
            {
                Console.WriteLine("A media das notas do Aluno foi de: " + media);
                Console.ReadLine();
            }
        }
    }
}
