using System;

namespace ModuloCliente
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = "André";
            cliente.Email = "andre@email.com";
            cliente.Cpf = "111.444.666.88";
            cliente.Idade = 23;

            Console.WriteLine(cliente);
        }
    }
}
