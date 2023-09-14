using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Controller
{
    public interface IRetornodados
    {
        string Autor();
        int Ano();
        int Edicao();
        int ID();
        long ISBN();
        string Pesquisa();
        string Titulo();
        string Nome();
        string Email();
        string Telefone();
        int Quantidade();
    }
}
