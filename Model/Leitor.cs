using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Biblioteca.Model
{
    public class Leitor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }

        public IList<Emprestimo> Emprestimos { get; set; }

        public Leitor(string nome, string email, string telefone)
        {            
            Nome = nome;
            Email = email;
            Telefone = telefone;
        }

        public Leitor()
        {
            Emprestimos = new List<Emprestimo>();
        }

        public override string? ToString()
        {
            return $"\nLeitor: {Id}\n" +
                $"Nome: {Nome}\n" +
                $"Email: {Email}\n" +
                $"Telefone: {Telefone}\n";
        }
    }
}
