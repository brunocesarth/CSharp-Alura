using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloCliente
{
    class Cliente
    {
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Idade { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome}, \n" +
                $"Email: {Email}, \n" +
                $"Idade: {Idade},\n" +
                $"CPF: {Cpf}";
        }
    }
}
