namespace Biblioteca.Controller
{
    internal interface IValidacao
    {
        bool Titulo(string valor);
        bool Nome(string valor);
        bool ISBN(string valor);
        bool Edicao (string valor);
        bool Ano (string valor);
        bool ID(string id);
    }
}