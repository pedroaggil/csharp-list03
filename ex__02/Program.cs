// Escreva um programa que exiba na tela em ordem decrescente, apenas os números ímpares existentes entre dois dois números digitados pelo usuário

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex__02
{
    class Program
    {
        static void main(string[] args)
        {
            int n1, n2;

            Console.Write("Digite um número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite outro número: ");
            n2 = int.Parse(Console.ReadLine());

            if (n2 > n1)
            {
                for (int number = n1; number >= n2; number--)
                {
                    if (number % 2 != 0)
                    {
                        Console.WriteLine(number);
                    }
                }

            } else
            {
                for (int number = n1; number <= n2; number--)
                {
                    if (number % 2 != 0)
                    {
                        Console.WriteLine(number);
                    }
                }

            }

            Console.ReadKey();
        }
    }
}
