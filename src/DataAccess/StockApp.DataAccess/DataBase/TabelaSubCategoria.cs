using Dapper;
using Microsoft.Data.SqlClient;

namespace StockApp.DataAccess.DataBase
{
    public partial class DatabaseService
    {
        public void CriarTabelaSubcategoria()
        {
            CriaTabelaSubcategoria();
        }
        private void CriaTabelaSubcategoria()
        {
            var sql = @"IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'SubCategorias')
                        BEGIN
                            CREATE TABLE SubCategorias
                            (
                                Id int PRIMARY KEY IDENTITY,
                                Nome varchar(100) NOT NULL,
                                CategoriaId int NOT NULL,
                                Status bit DEFAULT 1,
                                DataCriacao date NOT NULL DEFAULT CURRENT_TIMESTAMP,
                                DataAlteracao date NOT NULL DEFAULT CURRENT_TIMESTAMP,
                                CONSTRAINT fk_SubCategoria_Categoria
                                FOREIGN KEY (CategoriaId) REFERENCES Categorias(Id) ON DELETE CASCADE
                            )
                        END";
            using (var conexao = new SqlConnection(SqlConexao.ConexaoComBanco))
            {
                conexao.Open();
                conexao.Execute(sql);
            }
        }
    }
}
