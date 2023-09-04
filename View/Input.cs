using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.View
{
    internal class Input : IInput
    {
        public int Ano()
        {
            Console.WriteLine("Insira o ano:");
            return int.Parse(Console.ReadLine() + "");
        }

        public string Autor()
        {
            Console.WriteLine("Insira o autor:");
            return Console.ReadLine() + "";           
        }

        public int Edicao()
        {
            Console.WriteLine("Insira a edição:");
            return int.Parse(Console.ReadLine() + "");           
        }

        public int ID()
        {
            Console.WriteLine("Insira o ID:");
            return int.Parse(Console.ReadLine() + "");
        }

        public long ISBN()
        {
            Console.WriteLine("Insira o ISBN:");
            return long.Parse(Console.ReadLine() + "");
        }

        public string Pesquisa()
        {
            Console.WriteLine("Insira a pesquisa:");
            return Console.ReadLine() + "";
        }

        public string Titulo()
        {
            Console.WriteLine("Insira o título:");
            return Console.ReadLine() + "";           
        }
    }
}
