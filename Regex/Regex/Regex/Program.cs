using System;
using System.Text.RegularExpressions;

namespace RegexTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testando valor
            Console.Write("Informe um valor: ");
            var caracteres = Console.ReadLine();

            bool ok = Regex.IsMatch(caracteres, "^[0-9]+$");
            if (!ok)
            {
                Console.WriteLine("O valor informado não é um númerico válido.");
            }
            else
            {
                Console.WriteLine("O valor informado é válido.");
            }

            // Testando CPF
            Console.WriteLine();
            Console.Write("Informe um cpf para validação: ");
            var cpf = Console.ReadLine();

            Regex regex = new Regex(@"([0-9]{4}[-]?[0-9]{2})|([0-9]{3}[\.]?[0-9]{3}[\.]?[0-9]{2})", RegexOptions.IgnoreCase);
            var combinou = regex.Match(cpf);
            if (combinou.Success)
            {
                Console.WriteLine("CPF no formato válido.");
            }
            else
            {
                Console.WriteLine("CPF inválido");
            }

            // Testando CPF com IsMatch
            Console.Write("Informe um CPF para validação: ");
            var cpf1 = Console.ReadLine();

            Regex regex1 = new Regex(@"([0-9]{4}[-]?[0-9]{2})|([0-9]{3}[\.]?[0-9]{3}[\.]?[0-9]{2})", RegexOptions.IgnorePatternWhitespace);
            if (regex1.IsMatch(cpf1))
            {
                Console.WriteLine("CPF válido.");
            }
            else
            {
                Console.WriteLine("CPF inválido.");
            }

            // Usando o .Match() para buscar string ou expressão
            var busca = "Mergulhando em tecnologia com a Alura.";
            Regex regex2 = new Regex("Alura", RegexOptions.IgnoreCase);
            Match match = regex.Match(busca);
            if (match.Success)
            {
                Console.WriteLine("string encontrada no texto");
            }
            else
            {
                Console.WriteLine("string não encontrada.");
            }
        }
    }
}
