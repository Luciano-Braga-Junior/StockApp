using StockApp.Business.Entidades;

namespace StockApp.Business.Interfaces
{
    public interface ICategoriaRepository
    {
        bool Incluir(Categoria categoria);
        bool Atualizar(Categoria categoria);
        bool Remover(int id);
        bool Ativar(int id);
        bool Inativar(int id);
        Categoria ObterPorId(int id);
        List<Categoria> ObterTodos();
        List<Categoria> ObterTodasAtivas();
    }
}
