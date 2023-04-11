﻿// Escreva um programa que leia 15 números inteiros e exiba na tela ao final, o maior número que foi digitado pelo usuário

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex__05
{
    class Program
    {
        static void main(string[] args)
        {
			int[] array = new int[15];
			int number, i, more;

            for (i = 0; i <= 14; i++)
            {
				Console.WriteLine("Digite um número: ");
				number = int.Parse(Console.ReadLine());

				array[i] = number;
            }
            if (i > 0)
            {
                more = array[0];

                for (int n = 1; n <= 14; n++)
                {
                    if (more > array[n])
                    {
                        more = array[n];
                    }
                }
            } else
            {
                Console.WriteLine("Nenhum valor foi digitado.");
            }

            Console.WriteLine("O maior número informado é " + more);

            Console.ReadKey();
        }
    }
}