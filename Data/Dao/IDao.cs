using Biblioteca.Model;

namespace Biblioteca.Data
{
    public interface IDao<T>
    {
        void Adicionar(T obj);
        T? Listar(int id);
        IList<T> ListarTodos();
    }
}