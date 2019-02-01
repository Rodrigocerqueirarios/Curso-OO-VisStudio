using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            int ven, bomb, temp, calc, calc_tot;

            Console.Write("Digite a quantidade de Veneno ML: ");
            ven = int.Parse(Console.ReadLine());
            Console.Write("Digite volume da Vazão da Bomba ML/s: ");
            bomb = int.Parse(Console.ReadLine());
            Console.Write("Digite Tempo de uso /s: ");
            temp = int.Parse(Console.ReadLine());

            calc = bomb * temp;

            if (calc > ven)
            {
                Console.WriteLine("Não é Possivél!");
                Console.ReadLine();

                calc_tot = ven / bomb;

                Console.WriteLine("Como informação, o tempo total de difusão maximo do veneno para os parametros apresentados é de: " + calc_tot + " segundos");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("A quandidade de veneno restante para o tempo solicitado é: " + (ven - calc));
                Console.ReadLine();

                calc_tot = ven / bomb;

                Console.WriteLine("Como informação, o tempo total de difusão do veneno para os parametros apresentados é de: " + calc_tot + " segundos");
                Console.ReadLine();
            }
        }
    }
}
