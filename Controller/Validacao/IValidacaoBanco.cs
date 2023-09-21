using Biblioteca.Model;

namespace Biblioteca.Controller
{
    public interface IValidacaoBanco
    {
        bool ExisteDevolucao(int id);
        bool ExisteEmprestimo(int id);
        bool ExisteLeitor(int id);
        bool ExisteLivro(int id);
        bool QuantidadeLimite(int id);
        bool EstaAtivo(int id);
        bool ExiteEmprestimoIgual(int idLeitor, int idLivro);
    }
}