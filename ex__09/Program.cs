// Escreva um programa que leia vários números inteiros e ao final informe quantos números pares, quantos números ímpares, quantos números positivos e quantos números negativos foram digitados pelo usuário

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex__09
{
    class Program
    {
        static void main(string[] args)
        {
            int number, par = 0, imp = 0, pos = 0, neg = 0;
                string res = "S";

                do
                {
                    Console.Write("Digite um número: ");
                    number = int.Parse(Console.ReadLine());

                    if (number % 2 == 0)
                    {
                        par++;
                    }
                    else
                    {
                        imp++;
                    }

                    if (number >= 0)
                    {
                        pos++;
                    }
                    else
                    {
                        neg++;
                    }

                    Console.Write("Deseja encerrar o programa (S/N)? ");
                    res = Console.ReadLine();

                } while (res != "S" && res != "s");

                Console.WriteLine("Pares: " + par);
                Console.WriteLine("Ímpares: " + imp);
                Console.WriteLine("Positivos: " + pos);
                Console.WriteLine("Negativos: " + neg);

            Console.ReadKey();
        }
    }
}