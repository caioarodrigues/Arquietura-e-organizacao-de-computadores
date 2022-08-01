using Parte_3.Entities;
using Parte_3.Entities.Enums;
using System;

namespace Parte_3
{
    public class Program
    {
        static void Main()
        {
            //bool a = 1, b = 1, c = 0;

            LogicCircuit logicCircuit = new LogicCircuit(Circuit.Or);
            Console.WriteLine(logicCircuit.Or(true, false));

            Console.ReadLine();
        }
    }
}