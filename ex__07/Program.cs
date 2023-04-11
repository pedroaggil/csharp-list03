// Escreva um programa que exiba todos os números de 1 a 100 e a cada número que for múltiplo de 10, exiba a mensagem “MÚLTIPLO DE 10”

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex__07
{
    class Program
    {
        static void main(string[] args)
        {
            for (int i = 1; i <= 100; i++) {
                if (i % 10 != 0) {
                    Console.WriteLine(i);
                } else {
                    Console.WriteLine("{0} - MULTIPLO DE 10", i);
                }
            }

            Console.ReadKey();
        }
    }
}