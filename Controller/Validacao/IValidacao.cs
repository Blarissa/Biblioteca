namespace Biblioteca.Controller
{
    public interface IValidacao
    {
        bool Titulo(string valor);
        bool Nome(string valor);
        bool ISBN(string valor);
        bool Edicao(string valor);
        bool Ano(string valor);
        bool ID(string valor);
        bool Email(string valor);
        bool Telefone(string valor);
        bool Quantidade(string valor);
    }
}