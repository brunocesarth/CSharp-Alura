using System;
using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitario;

Funcionario pedro = new Funcionario();
pedro.Nome = "Pedro Malazartes";
pedro.Cpf = "123456789";
pedro.Salario = 2000;

Console.WriteLine(pedro.Nome);
Console.WriteLine(pedro.GetBonificacao());
Console.WriteLine(pedro.PremioSemestral());

Diretor roberta = new Diretor();
roberta.Nome = "Roberta Silva";
roberta.Cpf = "987654321";
roberta.Salario = 5000;

Console.WriteLine(roberta.Nome);
Console.WriteLine(roberta.GetBonificacao());
Console.WriteLine(roberta.PremioSemestral());

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
gerenciador.Registrar(pedro);
gerenciador.Registrar(roberta);
gerenciador.RegistraPremio(pedro);
gerenciador.RegistraPremio(roberta);

Console.WriteLine("Total de bonificações: " + gerenciador.TotalDeBonificacao);

Console.WriteLine("Total premiação semestral: " + gerenciador.TotalPremioSemestral);
