using bytebank.Modelos.Conta;
using bytebank_ATENDIMENTO.bytebank.Atendimento;
using GeradorDeListas;
Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");
//new ByteBankAtendimento().AtendimentoCliente();

List<object> Contas = new List<object>() {
    new ContaCorrente(95, "123456-X"){Saldo=100,Titular = new Cliente{Cpf="11111",Nome ="Henrique"}},
          new ContaCorrente(95, "951258-X"){Saldo=200,Titular = new Cliente{Cpf="22222",Nome ="Pedro"}},
          new ContaCorrente(94, "987321-W"){Saldo=60,Titular = new Cliente{Cpf="33333",Nome ="Marisa"}},
          new ContaCorrente(97, "987321-Z"){Saldo=1000,Titular = new Cliente{Cpf="44444",Nome ="Maria"}}
};

var listaDeContas = new GeradorListas();

listaDeContas.ExportarLista(Contas);
