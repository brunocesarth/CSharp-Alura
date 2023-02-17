using System;
using Desafio1.Operacoes;

namespace Desafio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo a calculadora braba");
            Console.WriteLine("Qual operação deseja Realizar? ");
            Console.WriteLine("Digite o número correspondente  \n" +
                "[1] Soma\n" +
                "[2] Multiplicação\n" +
                "[3] Subtração \n" +
                "[4] Divisão \n" +
                "[5] Sair");
            int escolha = int.Parse(Console.ReadLine());
            int numero1, numero2;

            switch (escolha)
            {
                case 1:
                    Console.Write("Digite o 1º Número: ");
                    numero1 = int.Parse(Console.ReadLine());
                    Console.Write("Digite o 2º Número: ");
                    numero2 = int.Parse(Console.ReadLine());
                    Soma soma = new Soma(numero1, numero2);
                    Console.WriteLine(soma);
                    break;
                case 2:
                    Console.Write("Digite o 1º Número: ");
                    numero1 = int.Parse(Console.ReadLine());
                    Console.Write("Digite o 2º Número: ");
                    numero2 = int.Parse(Console.ReadLine());
                    Multiplicacao multiplicacao = new Multiplicacao(numero1, numero2);
                    Console.WriteLine(multiplicacao);
                    break;
                case 3:
                    Console.Write("Digite o 1º Número: ");
                    numero1 = int.Parse(Console.ReadLine());
                    Console.Write("Digite o 2º Número: ");
                    numero2 = int.Parse(Console.ReadLine());
                    Subtracao subtracao = new Subtracao(numero1, numero2);
                    Console.WriteLine(subtracao);
                    break;
                case 4:
                    Console.Write("Digite o 1º Número: ");
                    numero1 = int.Parse(Console.ReadLine());
                    Console.Write("Digite o 2º Número: ");
                    numero2 = int.Parse(Console.ReadLine());
                    Divisao divisao = new Divisao(numero1, numero2);
                    Console.WriteLine(divisao);
                    break;
            }
        }
    }
}
