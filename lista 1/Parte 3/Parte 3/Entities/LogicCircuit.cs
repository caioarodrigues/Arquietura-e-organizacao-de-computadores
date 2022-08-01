using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parte_3.Entities.Enums;

namespace Parte_3.Entities
{
    internal class LogicCircuit
    {
        public Circuit Circuit { get; set; }
        //public bool Value { get; set; }
        public LogicCircuit(Circuit circuit)
        {
            Circuit = circuit;
        }
        public LogicCircuit()
        {
        }
        public bool And(bool a, bool b)
        {
            if (a == true && b == true)
                return true;
            return false;
        }
        public bool Not(bool lC)
        {
            if (lC == true)
                return false;
            return true;
        }
        public bool Or(bool a, bool b)
        {
            if (a == true || b == true)
                return true;
            return false;
        }
        public bool Or(bool a, bool b, bool c)
        {
            if (a == true || b == true || c == true)
                return true;
            return false;
        }
        public bool Nand(bool a, bool b)
        { 
            return Not(And(a, b));
        }
        public bool Nor(bool a, bool b)
        {
            return Not(Or(a, b));
        }

        public override string ToString()
        {
            return $"Type: {Circuit}";
        }
    }
}
