// Escreva um programa que informe a tabuada de um número a ser digitado pelo usuário

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex__03
{
    class Program
    {
        static void main(string[] args)
        {
            Console.Write("Digite um número para que lhe seja mostrado sua tabuada (de 1 a 10): ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", number, i, number * i);

            }

            Console.ReadKey();
        }
    }
}
