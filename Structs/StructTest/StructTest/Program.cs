using System;

namespace StructTest
{
    class Program
    {
        public struct Pessoa
        {
            public int Idade { get; set; }
            public string Nome { get; set; }
            public string Cpf { get; set; }
            public string Email { get; set; }

            public override string ToString()
            {
                return $"Nome: {Nome}" +
                    $"Email: {Email}";
            }
        }

        static void Main(string[] args)
        {
            Pessoa pessoa = new();
            pessoa.Cpf = "111.111.111-66";
            pessoa.Nome = "André Silva";
            pessoa.Email = "andre@email.com";
            pessoa.Idade = 36;

            Console.WriteLine(pessoa);
        }
    }
}
