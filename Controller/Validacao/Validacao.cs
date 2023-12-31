﻿using Biblioteca.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Controller
{
    public class Validacao : IValidacao
    {
        public bool Ano(string valor)
        {
            if (ValidacaoFormato.Ano(valor) &&
                ValidacaoRegras.Ano(valor))
                return true;

            return false;
        }

        public bool Edicao(string valor)
        {
            if (ValidacaoFormato.Edicao(valor))
                return true;

            return false;
        }

        public bool Email(string valor)
        {
            if(ValidacaoFormato.Email(valor))
                return true;

            return false;
        }

        public bool ID(string valor)
        {
            if (ValidacaoFormato.ID(valor))
                return true;

            return false;
        }

        public bool ISBN(string valor)
        {
            if (ValidacaoFormato.ISBN(valor))
                return true;

            return false;
        }

        public bool Nome(string valor)
        {
            if (ValidacaoFormato.Nome(valor))
                return true;

            return false;
        }

        public bool Quantidade(string valor)
        {
            if(ValidacaoFormato.Quantidade(valor))
                return true;
            
            return false;
        }

        public bool Telefone(string valor)
        {
            if(ValidacaoFormato.Telefone(valor))
                return true;

            return false;
        }

        public bool Titulo(string valor)
        {
            if (ValidacaoFormato.Nome(valor))
                return true;

            return false;
        }
    }
}
