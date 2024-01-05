using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO
{
    class Xenlonguinho
    {
        static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());

            for (int i = 0; i < numero; i++)
            {
                int qtdEsferas = int.Parse(Console.ReadLine());
                int contEsferas = 0;

                for (int j = 1; j <= qtdEsferas; j++)
                {
                    int contDivisores = 0;

                    for (int estrelas = 1; estrelas <= j; estrelas++)
                    {
                        if (j % estrelas == 0) contDivisores++;
                    }

                    if (contDivisores % 2 == 0) contEsferas++;
                }

                Console.WriteLine(contEsferas);
            }
        }
    }
}