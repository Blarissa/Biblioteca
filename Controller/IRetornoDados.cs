using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Controller
{
    internal interface IRetornodados
    {
        string Autor();
        int Ano();
        int Edicao();
        int ID();
        long ISBN();
        string Pesquisa();
        string Titulo();
    }
}
