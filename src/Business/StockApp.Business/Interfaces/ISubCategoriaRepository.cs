using StockApp.Business.Entidades;

namespace StockApp.Business.Interfaces
{
    public interface ISubCategoriaRepository
    {
        bool Incluir(Subcategoria categoria);
        bool Atualizar(Subcategoria categoria);
        bool Remover(int id);
        bool Ativar(int id);
        bool Inativar(int id);
        Subcategoria ObterPorId(int id);
        List<Subcategoria> ObterTodos();
        List<Subcategoria> ObterTodasAtivas();
    }
}
