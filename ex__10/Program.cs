// Faça um programa que leia as variáveis C e N, respectivamente código e número de horas trabalhadas de um operário. Calcule o salário sabendo-se que ele ganha R$ 10,00 por hora. Quando o número de horas exceder a 50, calcule o excesso de pagamento armazenando-o na variável E, caso contrário zerar tal variável. A hora excedente de trabalho vale R$ 20,00. No final do processamento imprimir o salário total e o salário excedente

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex__10
{
    class Program
    {
        static void main(string[] args)
        {
            int c, n, e = 0, sal, exc;
                string res;

                do
                {
                    Console.Write("Digite o código do operário: ");
                    c = int.Parse(Console.ReadLine());

                    Console.Write("Digite a quantidade de horas trabalhadas: ");
                    n = int.Parse(Console.ReadLine());

                    if (n <= 50)
                    {
                        sal = n * 10;

                        Console.WriteLine("Salário total: R$ " + sal + ",00");
                        Console.WriteLine("Valor excedente: R$ 0,00");
                    }
                    else
                    {
                        e = n - 50;
                        exc = e * 20;
                        sal = exc + (50 * 10);

                        Console.WriteLine("Salário total: R$ " + sal + ",00");
                        Console.WriteLine("Valor excedente: R$ " + exc + ",00");
                    }

                    Console.Write("Deseja encerrar o programa (S/N)? ");
                    res = Console.ReadLine();

                } while (res != "S" && res != "s");

                Console.ReadKey();

            Console.ReadKey();
        }
    }
}