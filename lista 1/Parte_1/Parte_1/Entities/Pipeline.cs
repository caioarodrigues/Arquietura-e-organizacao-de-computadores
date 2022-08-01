using Parte_1.Entities.Enums;

namespace Parte_1.Entities
{
    internal class Pipeline
    {
        public Estado Estado { get; set; }
        public int QtdeEstados { get { return 5; } }
        public int Identificador { get; set; }
        private int _contGravando = 0;
        public Pipeline()
        {
        }

        public void AttEstado()
        {
            switch (Estado)
            {
                case Estado.Buscando:
                    Estado = Estado.Decodificando;
                    break;
                case Estado.Decodificando:
                    Estado = Estado.BuscandoOperando;
                    break;
                case Estado.BuscandoOperando:
                    Estado = Estado.Executando;
                    break;
                case Estado.Executando:
                    Estado = Estado.Gravando;
                    break;
                case Estado.Gravando:
                    _contGravando++;
                    break;
                default:
                    break;
            }
        }

        public override string ToString()
        {
            if (Estado == Estado.BuscandoOperando)
                return $"Buscando operandos L{Identificador}"; //aqui conserta o erro do enumerável que não aceita mais de uma palavra
            //else if (Estado == Estado.Gravando)
            //    return null;
            else if (_contGravando > 0) 
            {
                _contGravando = 0;
                return null;
            }
            return $"{Estado} L{Identificador}";
        }
    }
}
