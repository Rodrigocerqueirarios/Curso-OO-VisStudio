using System;
using System.Globalization;

namespace Exercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal arr1, arr2, arr3;

            Console.Write ("Digite a distancia dos arremeços separados por espaço: ");
            string[] vet = Console.ReadLine().Split(' ');
            arr1 = decimal.Parse(vet[0], CultureInfo.InvariantCulture);
            arr2 = decimal.Parse(vet[1], CultureInfo.InvariantCulture);
            arr3 = decimal.Parse(vet[2], CultureInfo.InvariantCulture);

            if (arr1 > arr2 && arr1 > arr3)
            {
                Console.WriteLine("O melhor Lançamento foi o Arremeço 1 com: " + arr1.ToString(), CultureInfo.InvariantCulture);
                Console.ReadLine();
            }
            else if (arr2 > arr1 && arr2 > arr3)
            {
                Console.WriteLine("O melhor Lançamento foi o Arremeço 2 com: " + arr2.ToString(), CultureInfo.InvariantCulture);
                Console.ReadLine();
            }
            else if (arr3 > arr1 && arr3 > arr2)
            {
                Console.WriteLine("O melhor Lançamento foi o Arremeço 3 com: " + arr3.ToString(), CultureInfo.InvariantCulture);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Os Lançamentos tem a mesma distancia: " + arr1.ToString());
                Console.ReadLine();
            }
        }
    }
}
