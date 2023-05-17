using bytebank_ATENDIMENTO.bytebank.Atendimento;
using System;

namespace bytebank_ATENDIMENTO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");
            new ByteBankAtendimento().AtendimentoCliente();
        }
    }
}
