using System.Globalization;

namespace Desafio1.Operacoes
{
    class Divisao
    {
        public double Numero { get; set; }
        public double Divisor { get; set; }
        public double Resultado { get; set; }

        public Divisao(double numero, double divisor)
        {
            Numero = numero;
            Divisor = divisor;
            RealizaDivisao(Numero, Divisor);
        }

        public double RealizaDivisao(double numero, double divisor)
        {
            Resultado = numero / divisor;
            return Resultado;
        }

        public override string ToString()
        {
            return "O resultado da divisão é " + Resultado.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
