using Dapper;
using Microsoft.Data.SqlClient;

namespace StockApp.DataAccess.DataBase
{
    public partial class DatabaseService
    {
        public void CriarTabelaCategoria()
        {
            CriaTabelaCategoria();
        }
        private void CriaTabelaCategoria()
        {
            var sql = @"IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Categorias')
                        BEGIN
                            CREATE TABLE Categorias
                            (
                                Id int PRIMARY KEY,
                                Nome varchar(100) NOT NULL,
                                Status bit DEFAULT 1,
                                DataCriacao date NOT NULL DEFAULT CURRENT_TIMESTAMP,
                                DataAlteracao date NOT NULL DEFAULT CURRENT_TIMESTAMP
                            );
                        END";
            using (var conexao = new SqlConnection(SqlConexao.ConexaoComBanco))
            {
                conexao.Open();
                conexao.Execute(sql);
            }
        }
    }
}
