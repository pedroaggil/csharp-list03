// Escreva um programa que calcule o fatorial de um número informado pelo usuário

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex__08
{
    class Program
    {
        static void main(string[] args)
        {
            int res = 1;

            Console.Write("Digite um número para que seja calculado o seu fatorial: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("{0}! =", number);
   
            for (int i = 2; i <= number; i++) {
                res = res * i;
                Console.Write("* {0} ", i);
            }

            Console.Write("= {0}", res);

            Console.ReadKey();
        }
    }
}