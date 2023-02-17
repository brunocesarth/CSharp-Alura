using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1.Operacoes
{
    class Multiplicacao
    {
        public int Numero { get; set; }
        public int Multiplicador { get; set; }
        public int Resultado { get; set; }

        public Multiplicacao(int numero, int multiplicador)
        {
            Numero = numero;
            Multiplicador = multiplicador;
            RealizaMultiplicacao(Numero, Multiplicador);
        }

        public int RealizaMultiplicacao(int numero, int multiplicador)
        {
            Resultado = numero * multiplicador;
            return Resultado;
        }

        public override string ToString()
        {
            return "O resultado da multiplicação é " + Resultado;
        }
    }
}
