using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Controller
{
    internal class ValidacaoRegras
    {
        public static bool Ano(string valor)
        {
            var ano = int.Parse(valor);

            if (ano > DateTime.Now.Year)
                return false;

            return true;
        }
    }
}
