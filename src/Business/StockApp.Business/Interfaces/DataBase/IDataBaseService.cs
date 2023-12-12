namespace StockApp.Business.Interfaces.DataBase
{
    public interface IDataBaseService
    {
        void CriarBanco();
        void CriarTabelaCategoria();
        void CriarTabelaSubcategoria();
    }
}
