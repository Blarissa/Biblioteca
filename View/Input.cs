﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.View
{
    internal class Input : IInput
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

        public string LerID()
        {
            Console.WriteLine("Insira o ID:");
            return Console.ReadLine() + "";
        }

        public string LerISBN()
        {
            Console.WriteLine("Insira o ISBN:");
            return Console.ReadLine() + "";
        }

        public string LerPesquisa()
        {
            Console.WriteLine("Insira a pesquisa:");
            return Console.ReadLine() + "";
        }

        public string LerTitulo()
        {
            Console.WriteLine("Insira o título:");
            return Console.ReadLine() + "";           
        }
    }
}
