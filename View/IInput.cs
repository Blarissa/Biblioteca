using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.View
{
    public interface IInput
    {
        string LerAutor();
        string LerAno();
        string LerEdicao();
        string LerID();
        string LerIDLivro();
        string LerIDLeitor();
        string LerIDEmprestimo();
        string LerISBN();
        string LerPesquisa();
        string LerTitulo();
        string LerEmail();
        string LerNome();
        string LerTelefone();
        string LerQuantidade();        
    }
}
