using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio2.Entities
{
    class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string ISBN { get; set; }
        public DateTime AnoPublicacao { get; set; }
        public string Categoria { get; set; }
        public int NumeroDePaginas { get; set; }
        public string PaisDePublicacao { get; set; }

        public Livro(string titulo, string iSBN)
        {
            Titulo = titulo;
            ISBN = iSBN;
        }

        public override string ToString()
        {
            return $"Livro: {Titulo} / ISBN: {ISBN}";
        }
    }
}
