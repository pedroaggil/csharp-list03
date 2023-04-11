// Conte os números ímpares entre dois números dados pelo usuário

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex__04
{
    class Program
    {
        static void main(string[] args)
        {
            Console.Write("Digite um número: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite outro número: ");
            int n2 = int.Parse(Console.ReadLine());

            int imp = 0, under, more;

            if (n1 <= n2)
            {
                under = n1;
                more = n2;
            } else
            {
                under = n2;
                more = n1;
            }

            for (int i = under; i <= more; i++)
            {
                if (i % 2 != 0) { imp++; }
            }

            Console.WriteLine("Há {0} números ímpares entre {1} e {2}.", imp, under, more);

            Console.ReadKey();
        }
    }
}
