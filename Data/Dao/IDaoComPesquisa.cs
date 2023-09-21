using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Data.Dao
{
    public interface IDaoComPesquisa<T> : IDao<T>
    {
        IList<T> Pesquisar(string pesquisa);
    }
}
