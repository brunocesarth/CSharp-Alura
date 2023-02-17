using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1.Operacoes
{
    class Soma
    {
        public int Numero1 { get; set; }
        public int Numero2 { get; set; }

        public int Resultado { get; set; }

        public Soma(int numero1, int numero2)
        {
            Numero1 = numero1;
            Numero2 = numero2;
            RealizaSoma(numero1, numero2);
        }

        public int RealizaSoma(int numero1, int numero2)
        {
            Resultado = numero1 + numero2;
            return Resultado;
        }

        public override string ToString()
        {
            return "O resultado da soma é " + Resultado;
        }

    }
}
