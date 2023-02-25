using System;
using System.Collections.Generic;

List<string> nomesDosEscolhidos = new List<string>()
{
    "Bruce Wayne",
    "Carlos Vilagran",
    "Richard Grayson",
    "Bob Kane",
    "Will Farrel",
    "Lois Lane",
    "General Welling",
    "Perla Letícia",
    "Uxas",
    "Diana Prince",
    "Elisabeth Romanova",
    "Anakin Wayne"
};

BuscarNome();
void BuscarNome()
{
    Console.Write("Digite um nome para procurar: ");
    string nomeBusca = Console.ReadLine();

    foreach(string nome in nomesDosEscolhidos)
    {
        if (nome.Equals(nomeBusca))
        {
            Console.WriteLine($"Nome encontrado = {nomeBusca}.");
            break;
        }
    }
}

