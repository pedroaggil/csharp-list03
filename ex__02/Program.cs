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

                if (n1 >= n2)
                {
                    for (int i = n1; i >= n2; i--)
                    {
                        if (i % 2 != 0) { Console.WriteLine(i); }
                    }

                }
                else
                {
                    for (int i = n2; i >= n1; i--)
                    {
                        if (i % 2 != 0) { Console.WriteLine(i); }
                    }
                }

Console.ReadKey();
        }
    }
}
