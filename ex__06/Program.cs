// Escreva um programa que calcule e exiba a média de 10 notas digitadas pelo usuário. Considerar notas válidas, somente valores entre 0 (zero) e 10 (dez)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex__06
{
    class Program
    {
        static void main(string[] args)
        {
            int average, sum = 0, mention;

                for (int i = 1; i <= 10; i++)
                {

                    do
                    {
                        Console.Write("Insira a {0}° menção: ", i);
                        mention = int.Parse(Console.ReadLine());

                        if (mention < 0 || mention > 10)
                        {
                            Console.WriteLine("Insira valores válidos (entre 0 e 10), por favor.");
                        }

                    } while (mention < 0 || mention > 10);
                    sum = sum + mention;
                }

                average = sum / 10;
                Console.WriteLine("A média final do indivíduo avaliado é: " + media);

            Console.ReadKey();
        }
    }
}