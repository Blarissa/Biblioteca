using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Model
{
    internal class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public long ISBN { get; set; }
        public int Ano { get; set; }
        public int Edicao { get; set; }

        public Livro(string titulo, string autor, long iSBN, int ano, int edicao)
        {
            Titulo = titulo;
            Autor = autor;
            ISBN = iSBN;
            Ano = ano;
            Edicao = edicao;
        }

        public override string? ToString()
        {
            return $"Livro\n" +
                $"Id: {Id}\n" +
                $"Título: {Titulo}\n" +
                $"Autor: {Autor}\n" +
                $"Ano: {Ano}\n" +
                $"Edição: {Edicao}\n";
        }
    }
}
