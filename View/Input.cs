using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.View
{
    public class Input : IInput
    {
        public string LerAno()
        {
            Console.WriteLine("Insira o ano:");
            return Console.ReadLine() + "";
        }

        public string LerAutor()
        {
            Console.WriteLine("Insira o autor:");
            return Console.ReadLine() + "";           
        }

        public string LerEdicao()
        {
            Console.WriteLine("Insira a edição:");
            return Console.ReadLine() + "";           
        }

        public string LerEmail()
        {
            Console.WriteLine("Insira o email:");
            return Console.ReadLine() + "";
        }

        public string LerID()
        {
            Console.WriteLine("Insira o ID:");
            return Console.ReadLine() + "";
        }

        public string LerIDLivro()
        {
            Console.WriteLine("Insira o ID do livro:");
            return Console.ReadLine() + "";
        }

        public string LerIDLeitor()
        {
            Console.WriteLine("Insira o ID do leitor:");
            return Console.ReadLine() + "";
        }
        
        public string LerIDEmprestimo()
        {
            Console.WriteLine("Insira o ID do empréstimo:");
            return Console.ReadLine() + "";
        }

        public string LerISBN()
        {
            Console.WriteLine("Insira o ISBN:");
            return Console.ReadLine() + "";
        }

        public string LerNome()
        {
            Console.WriteLine("Insira o nome:");
            return Console.ReadLine() + "";
        }

        public string LerPesquisa()
        {
            Console.WriteLine("Insira a pesquisa:");
            return Console.ReadLine() + "";
        }

        public string LerQuantidade()
        {
            Console.WriteLine("Insira a quantidade:");
            return Console.ReadLine() + "";
        }

        public string LerTelefone()
        {
            Console.WriteLine("Insira o telefone:");
            return Console.ReadLine() + "";
        }

        public string LerTitulo()
        {
            Console.WriteLine("Insira o título:");
            return Console.ReadLine() + "";           
        }
    }
}
