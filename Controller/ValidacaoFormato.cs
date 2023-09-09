using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Controller
{
    internal class ValidacaoFormato
    {
        public static bool Ano(string valor)
        {
            if (!ENulo(valor) &&
                int.TryParse(valor, out int _))
                return true;

            return false;
        }

        private static bool ENulo(string valor)
        {
            return string.IsNullOrEmpty(valor);
        }

        public static bool ISBN(string valor)
        {
            if (!ENulo(valor) && valor.Count() == 10)
                return true;
               
            return false;
        }

        public static bool Edicao(string valor)
        {
            if(!ENulo(valor) && 
                int.TryParse(valor, out int _))
                return true;

            return false;
        }

        public static bool Nome(string valor)
        {
            if(!ENulo(valor) && valor.Count() >= 5)
                return true;
            
            return false;
        }

        public static bool ID(string valor)
        {
            if(!ENulo(valor) &&
                int.TryParse(valor, out int _))
                return true;

            return false;
        }
    }
}
