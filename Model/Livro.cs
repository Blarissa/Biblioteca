using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Model
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public long ISBN { get; set; }
        public int Ano { get; set; }
        public int Edicao { get; set; }
        public int Quantidade { get; set; }

        public IList<Emprestimo> Emprestimos { get; set; }

        public Livro(string titulo, string autor, long iSBN, int ano, int edicao, int quantidade)
        {
            Titulo = titulo;
            Autor = autor;
            ISBN = iSBN;
            Ano = ano;
            Edicao = edicao;
            Quantidade = quantidade;
        }

        public Livro()
        {
            Emprestimos = new List<Emprestimo>();
        }

        public override string? ToString()
        {
            return $"\nLivro: {Id}\n" +
                $"Título: {Titulo}\n" +
                $"Autor: {Autor}\n" +
                $"ISBN: {ISBN}\n" +
                $"Ano: {Ano}\n" +
                $"Edição: {Edicao}\n" +
                $"Quantidade: {Quantidade}\n";
        }
    }
}
