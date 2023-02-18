using System;
using Desafio2.Entities;

namespace Desafio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Livro livro1 = new Livro("O Nome do Vento", "8599296493");
            Livro livro2 = new Livro("O Teste do Fogo", "4654653462");
            Livro livro3 = new Livro("A Cura da Água", "4654653813");
            Livro livro4 = new Livro("A Maldição da Terra", "4654653462");

            Console.WriteLine(livro1);
            Console.WriteLine(livro2);
            Console.WriteLine(livro3);
            Console.WriteLine(livro4);
        }
    }
}
