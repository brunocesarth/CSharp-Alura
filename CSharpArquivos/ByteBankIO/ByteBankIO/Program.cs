﻿using System;
using System.IO;

partial class Program
{
    static void Main(string[] args)
    {
        var enderecoDoArquivo = "contas.txt";

        using(var fluxoDeArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        {
            var leitor = new StreamReader(fluxoDeArquivo);

            // var linha = leitor.ReadLine();

            // var texto = leitor.ReadToEnd();

            //var numero = leitor.Read(); //Trás o primeiro byte do arquivo

            while (!leitor.EndOfStream)
            {
                var linha = leitor.ReadLine();
                Console.WriteLine(linha);
            }
        }
        Console.ReadLine();
    }
}
