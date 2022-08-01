using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parte_1.Entities;

namespace Parte_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Insira a quantidade de instruções: ");
            int qtde = int.Parse(Console.ReadLine());

            Console.Clear();

            Pipeline[] pipe = new Pipeline[qtde];

            for (a = 0; a < qtde; a++) // arrumar essa joça depois
                pipe[a] = new Pipeline();

            for (int i = 0; i < qtde; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    pipe[i].Identificador = i - j + 1;
                    Console.WriteLine(pipe[i]);
                    pipe[i].AttEstado();
                }
                Console.WriteLine("------------------------");
            }

            Console.ReadLine();
        }
    }
}
