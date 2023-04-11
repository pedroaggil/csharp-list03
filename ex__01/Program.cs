// Escreva um programa que exiba na tela em ordem crescente, apenas os números pares existentes entre 11 e 250

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex__01
{
    class Program
    {
        static void main(string[] args)
        {
            for (int number = 11; number <= 250; number++)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine(number);
                }
            }

            Console.ReadKey();
        }
    }
}
