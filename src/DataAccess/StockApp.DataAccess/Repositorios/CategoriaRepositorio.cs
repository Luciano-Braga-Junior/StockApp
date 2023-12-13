using Dapper;
using Microsoft.Data.SqlClient;
using StockApp.Business.Entidades;
using StockApp.Business.Interfaces;

namespace StockApp.DataAccess.Repositorios
{
    public class CategoriaRepositorio : ICategoriaRepository
    {
        public bool Ativar(int id)
        {
            throw new NotImplementedException();
        }
        public bool Atualizar(Categoria categoria)
        {
            throw new NotImplementedException();
        }
        public bool Inativar(int id)
        {
            throw new NotImplementedException();
        }
        public bool Incluir(Categoria categoria)
        {
            var sql = @"INSERT INTO Categorias(Nome, Status)
                        VALUES (@Nome , @Status)";
            try
            {
                using (var conexao = new SqlConnection(SqlConexao.ConexaoComBanco))
                {
                    conexao.Open();
                    var resultado = conexao.Execute(sql, categoria);
                    return resultado > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public Categoria ObterPorId(int id)
        {
            throw new NotImplementedException();
        }
        public List<Categoria> ObterTodasAtivas()
        {
            throw new NotImplementedException();
        }
        public List<Categoria> ObterTodos()
        {
            throw new NotImplementedException();
        }
        public bool Remover(int id)
        {
            throw new NotImplementedException();
        }
    }
}
